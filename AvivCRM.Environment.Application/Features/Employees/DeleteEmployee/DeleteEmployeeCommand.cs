using MediatR;

namespace AvivCRM.Environment.Application.Features.Employees.DeleteEmployee;
public class DeleteEmployeeCommand : IRequest
{
    public Guid Id { get; set; }
}
