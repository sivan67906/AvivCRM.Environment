using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Employees.GetEmployeeById;
public class GetEmployeeByIdQuery : IRequest<EmployeeDTO>
{
    public Guid Id { get; set; }
}
