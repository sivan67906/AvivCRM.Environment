using MediatR;

namespace AvivCRM.Environment.Application.Features.Messages.DeleteMessage;
public class DeleteMessageCommand : IRequest
{
    public Guid Id { get; set; }
}
