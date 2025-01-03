using AutoMapper;
using AvivCRM.Environment.Application.DTOs.LeadSources;
using AvivCRM.Environment.Application.Features.LeadSourcees.GetAllLeadSource;
using AvivCRM.Environment.Domain.Contracts.Lead;
using AvivCRM.Environment.Domain.Responses;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadSources.GetAllLeadSource;
internal class GetAllLeadSourceQueryHandler(ILeadSource _leadSourceRepository, IMapper mapper) : IRequestHandler<GetAllLeadSourceQuery, ServerResponse>
{
    public async Task<ServerResponse> Handle(GetAllLeadSourceQuery request, CancellationToken cancellationToken)
    {
        // Get all plan types
        var leadSource = await _leadSourceRepository.GetAllAsync();
        if (leadSource is null) return new ServerResponse(Message: "No Lead Source Found");

        // Map the plan types to the response
        var leadSourcResponse = mapper.Map<IEnumerable<GetLeadSource>>(leadSource);
        if (leadSourcResponse is null) return new ServerResponse(Message: "Lead Source Not Found");

        return new ServerResponse(IsSuccess: true, Message: "List of Lead Source", Data: leadSourcResponse);
    }
}


