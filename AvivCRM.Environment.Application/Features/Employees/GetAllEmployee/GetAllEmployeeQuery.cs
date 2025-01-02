using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Employees.GetAllEmployee;
public class GetAllEmployeeQuery : IRequest<IEnumerable<EmployeeDTO>>
{
}
