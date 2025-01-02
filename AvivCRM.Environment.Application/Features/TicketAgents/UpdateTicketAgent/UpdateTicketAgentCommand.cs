using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketAgents.UpdateTicketAgent;

public class UpdateTicketAgentCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketAgentCode { get; set; }
    public string? TicketAgentName { get; set; }
}














































