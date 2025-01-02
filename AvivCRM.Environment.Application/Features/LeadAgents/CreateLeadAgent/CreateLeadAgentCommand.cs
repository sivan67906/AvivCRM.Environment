using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.LeadAgents.CreateLeadAgent
{
    public record CreateLeadAgentCommand(CreateLeadAgentRequest LeadAgent) : IRequest<string>;
}


