using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketChannels.UpdateTicketChannel;

public class UpdateTicketChannelCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketChannelCode { get; set; }
    public string? TicketChannelName { get; set; }
}








































