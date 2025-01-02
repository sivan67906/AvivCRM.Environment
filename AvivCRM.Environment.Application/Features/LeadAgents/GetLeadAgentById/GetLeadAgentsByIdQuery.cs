using MediatR;
using AvivCRM.Environment.Domain.Responses;

namespace AvivCRM.Environment.Application.Features.LeadAgents.GetLeadAgentById;

public record GetLeadAgentsByIdQuery(int Id) : IRequest<ServerResponse>;


