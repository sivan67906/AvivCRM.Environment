using AvivCRM.Environment.Domain.Responses;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadSourcees.DeleteLeadSource;
public record DeleteLeadSourceCommand(Guid Id) : IRequest<ServerResponse>;