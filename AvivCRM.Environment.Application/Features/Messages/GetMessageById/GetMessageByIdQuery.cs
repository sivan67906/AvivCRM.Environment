using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Messages.GetMessageById;
public class GetMessageByIdQuery : IRequest<MessageDTO>
{
    public Guid Id { get; set; }
}
