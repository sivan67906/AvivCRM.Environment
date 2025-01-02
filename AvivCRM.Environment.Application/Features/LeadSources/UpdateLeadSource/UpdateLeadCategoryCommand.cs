using AvivCRM.Environment.Application.DTOs.LeadSources;
using AvivCRM.Environment.Domain.Responses;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadSourcees.UpdateLeadSource;

public record UpdateLeadSourceCommand(UpdateLeadSourceRequest LeadSource) : IRequest<ServerResponse>;