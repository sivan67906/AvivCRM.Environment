using MediatR;
using AvivCRM.Environment.Domain.Interfaces;
using AvivCRM.Environment.Domain.Responses;

namespace AvivCRM.Environment.Application.Features.LeadAgents.GetAllLeadAgents
{
    public class GetAllLeadAgentsQueryHandler : IRequestHandler<GetAllLeadAgentsQuery, ServerResponse>
    {
        public readonly IGenericRepository<Domain.Entities.LeadAgent> _repository;
        public GetAllLeadAgentsQueryHandler(IGenericRepository<Domain.Entities.LeadAgent> repository) => _repository = repository;

        public async Task<ServerResponse> Handle(GetAllLeadAgentsQuery request, CancellationToken cancellationToken)
        {
            return new ServerResponse(Message: "Not Implemented");
            //throw new NotImplementedException();
        }

        //public async Task<IEnumerable<LeadAgentDTO>> Handle(GetAllLeadAgentsQuery request, CancellationToken cancellationToken)
        //{
        //    var agent = await _repository.GetAllAsync();

        //    var agentList = agent.Select(x => new LeadAgentDTO
        //    {
        //        Id = x.Id,
        //        AgentName = x.AgentName,
        //    }).ToList();

        //    return agentList;
        //}
    }
}


