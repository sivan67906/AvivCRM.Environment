using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Messages.GetAllMessage;
public class GetAllMessageQuery : IRequest<IEnumerable<MessageDTO>>
{
}
