using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Employees.CreateEmployee;
public class CreateEmployeeCommandHandler(IGenericRepository<Domain.Entities.Employee> employee,
    IGenericRepository<Address> addressrepo)
    : IRequestHandler<CreateEmployeeCommand, Guid>
{
    public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            CityId = request.CityId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };
        var insertedAddress = await addressrepo.CreateAsyncwithEntity(address);

        var client = new Domain.Entities.Employee
        {
            EmployeeCode = request.EmployeeCode,
            EmployeeName = request.EmployeeName,
            Description = request.Description,
            DateOfBirth = request.DateOfBirth,
            CompanyId = request.CompanyId,
            PhoneNumber = request.PhoneNumber,
            AddressId = request.AddressId,
            CountryId = request.CountryId,
            DepartmentId = request.DepartmentId,
            StateId = request.StateId,
            CityId = request.CityId,
        };
        await employee.CreateAsync(client);
        return client.Id;
    }
}
