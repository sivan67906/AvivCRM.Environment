using AvivCRM.Environment.Domain.Responses;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadSourcees.GetAllLeadSource;

public record GetAllLeadSourceQuery : IRequest<ServerResponse>;