using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Tasks.GetAllTask;
public class GetAllTaskQuery : IRequest<IEnumerable<TaskDTO>>
{

}
