using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Employees.UpdateEmployee;
public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, Guid>
{
    private readonly IGenericRepository<Domain.Entities.Employee> _repository;
    private readonly IGenericRepository<Address> _addressRepository;
    public UpdateEmployeeCommandHandler(IGenericRepository<Domain.Entities.Employee> repository, IGenericRepository<Address> addressRepository)
    {
        _repository = repository;
        _addressRepository = addressRepository;
    }

    public async Task<Guid> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Id = request.Id,
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            CityId = request.CityId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };
        var insertedAddress = await _addressRepository.UpdateAsyncwithEntity(address);
        var product = new Domain.Entities.Employee
        {
            Id = request.Id,
            EmployeeCode = request.EmployeeCode,
            EmployeeName = request.EmployeeName,
            Description = request.Description,
            DateOfBirth = request.DateOfBirth,
            CompanyId = request.CompanyId,
            PhoneNumber = request.PhoneNumber,
            AddressId = request.AddressId,
            CountryId = request.CountryId,
            StateId = request.StateId,
            CityId = request.CityId,

        };
        await _repository.UpdateAsync(product);
        return request.Id;
    }
}
