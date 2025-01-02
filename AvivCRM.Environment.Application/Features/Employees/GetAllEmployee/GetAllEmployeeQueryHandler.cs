using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Employees.GetAllEmployee;
public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeDTO>>
{
    private readonly IGenericRepository<Domain.Entities.Employee> _employeerepo;
    public GetAllEmployeeQueryHandler(IGenericRepository<Domain.Entities.Employee> employeerepo)
    {
        _employeerepo = employeerepo;
    }

    public async Task<IEnumerable<EmployeeDTO>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
    {

        var companies = await _employeerepo.GetAllAsync();

        var businessLocationList = companies.Select(x => new EmployeeDTO
        {
            Id = x.Id,
            EmployeeCode = x.EmployeeCode,
            EmployeeName = x.EmployeeName,
            DateOfBirth = x.DateOfBirth,
            PhoneNumber = x.PhoneNumber,
            Description = x.Description,
            DepartmentId = x.DepartmentId,
            DepartmentName = x.Department.Name,
            CompanyId = x.CompanyId,
            CompanyName = x.Company.Name,
            AddressId = x.AddressId,
            Address1 = x.Address.Address1,
            Address2 = x.Address.Address2,
            ZipCode = x.Address.ZipCode,
            CountryId = x.CountryId,
            StateId = x.StateId,
            CityId = x.CityId,
            CountryName = x.Country.Name,
            StateName = x.State.Name,
            CityName = x.City.Name,
        }).ToList();

        return businessLocationList;
    }
}
