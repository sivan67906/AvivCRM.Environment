using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class Employee
{
    public Guid Id { get; set; }
    public int EmployeeCode { get; set; }
    public string? EmployeeName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Description { get; set; }

    [ForeignKey(nameof(DepartmentId))]
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }

    [ForeignKey(nameof(CompanyId))]
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }

    [ForeignKey(nameof(AddressId))]
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }

    [ForeignKey(nameof(CountryId))]
    public Guid CountryId { get; set; }
    public Country? Country { get; set; }

    [ForeignKey(nameof(StateId))]
    public Guid StateId { get; set; }
    public State? State { get; set; }

    [ForeignKey(nameof(CityId))]
    public Guid CityId { get; set; }
    public City? City { get; set; }
}
