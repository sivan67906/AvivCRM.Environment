﻿using MediatR;

namespace AvivCRM.Environment.Application.Features.Employees.CreateEmployee;
public class CreateEmployeeCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public int EmployeeCode { get; set; }
    public string? EmployeeName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Description { get; set; }
    public Guid CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public Guid AddressId { get; set; }
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public Guid DepartmentId { get; set; }
    public Guid CountryId { get; set; }
    public Guid StateId { get; set; }
    public Guid CityId { get; set; }
    public string DepartmentName { get; set; } = string.Empty;
    public string CountryName { get; set; } = string.Empty;
    public string StateName { get; set; } = string.Empty;
    public string CityName { get; set; } = string.Empty;
}