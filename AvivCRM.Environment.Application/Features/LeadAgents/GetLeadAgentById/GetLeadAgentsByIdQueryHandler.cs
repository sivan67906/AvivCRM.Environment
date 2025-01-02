using MediatR;
using AvivCRM.Environment.Domain.Interfaces;
using AvivCRM.Environment.Domain.Responses;

namespace AvivCRM.Environment.Application.Features.LeadAgents.GetLeadAgentById
{
    public class GetLeadAgentsByIdQueryHandler : IRequestHandler<GetLeadAgentsByIdQuery, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadAgentRepository;
        public GetLeadAgentsByIdQueryHandler(IGenericRepository<Domain.Entities.LeadAgent> leadAgentRepository) => _leadAgentRepository = leadAgentRepository;

        public async Task<ServerResponse> Handle(GetLeadAgentsByIdQuery request, CancellationToken cancellationToken)
        {
            return new ServerResponse(Message: "Not Implemented");
        }


        //public async Task<LeadAgentDTO> Handle(GetLeadAgentsByIdQuery request, CancellationToken cancellationToken)
        //{
        //    var product = await _leadAgentRepository.GetByIdAsync(request.Id);
        //    if (product == null) return null;
        //    return new LeadAgentDTO
        //    {
        //        Id = product.Id,
        //        AgentName = product.AgentName,
        //    };
        //}
    }
}


