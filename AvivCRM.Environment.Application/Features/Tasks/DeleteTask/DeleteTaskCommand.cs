using MediatR;

namespace AvivCRM.Environment.Application.Features.Tasks.DeleteTask;
public class DeleteTaskCommand : IRequest
{
    public Guid Id { get; set; }
}
