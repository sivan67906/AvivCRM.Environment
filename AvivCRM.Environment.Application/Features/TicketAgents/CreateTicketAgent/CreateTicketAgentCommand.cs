using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketAgents.CreateTicketAgent;

public class CreateTicketAgentCommand : IRequest
{
    public string? TicketAgentCode { get; set; }
    public string? TicketAgentName { get; set; }
}














































