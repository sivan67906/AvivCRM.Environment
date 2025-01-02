using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Employees.GetEmployeeById;
public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDTO>
{
    private readonly IGenericRepository<Domain.Entities.Employee> _employeerepo;
    public GetEmployeeByIdQueryHandler(IGenericRepository<Domain.Entities.Employee> employeerepo)
    {
        _employeerepo = employeerepo;
    }

    public async Task<EmployeeDTO> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _employeerepo.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new EmployeeDTO
        {
            Id = client.Id,
            EmployeeCode = client.EmployeeCode,
            EmployeeName = client.EmployeeName,
            Description = client.Description,
            DateOfBirth = client.DateOfBirth,
            PhoneNumber = client.PhoneNumber,
            DepartmentId = client.DepartmentId,
            DepartmentName = client.Department.Name,
            CompanyId = client.CompanyId,
            CompanyName = client.Company.Name,
            AddressId = client.AddressId,
            Address1 = client.Address.Address1,
            Address2 = client.Address.Address2,
            ZipCode = client.Address.ZipCode,
            CountryId = client.CountryId,
            StateId = client.StateId,
            CityId = client.CityId,
            CountryName = client.Country.Name,
            StateName = client.State.Name,
            CityName = client.City.Name,
        };
    }
}
