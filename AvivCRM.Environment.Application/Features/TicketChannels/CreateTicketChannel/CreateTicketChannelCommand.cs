using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketChannels.CreateTicketChannel;

public class CreateTicketChannelCommand : IRequest
{
    public string? TicketChannelCode { get; set; }
    public string? TicketChannelName { get; set; }
}








































