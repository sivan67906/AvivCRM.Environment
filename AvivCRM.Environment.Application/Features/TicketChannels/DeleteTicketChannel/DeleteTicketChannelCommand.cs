using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketChannels.DeleteTicketChannel
{
    public class DeleteTicketChannelCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































