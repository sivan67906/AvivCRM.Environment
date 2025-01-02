using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Tasks.GetTaskById;
public class GetTaskByIdQuery : IRequest<TaskDTO>
{
    public Guid Id { get; set; }
}
