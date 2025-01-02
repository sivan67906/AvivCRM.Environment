using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.LeadAgents.UpdateLeadAgent
{
    public record UpdateLeadAgentCommand(UpdateLeadAgentRequest LeadAgent) : IRequest<string>;
}


