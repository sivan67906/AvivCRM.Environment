using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadAgents.DeleteLeadAgent
{
    public class DeleteLeadAgentCommandHandler : IRequestHandler<DeleteLeadAgentCommand, string>
    {
        //private readonly IGenericRepository<Domain.Entities.LeadAgents> _repository;
        //public DeleteLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgents> repository)
        //{
        //    _repository = repository;
        //}
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadAgentRepo;
        public DeleteLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> leadAgentRepo)
        {
            _leadAgentRepo = leadAgentRepo;
        }

        //public Task<string> Handle(DeleteLeadAgentCommand request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<string> Handle(DeleteLeadAgentCommand request, CancellationToken cancellationToken)
        {
            //if (request == null || request.Id <= 0)
            //{
            //    return "Request or Request.Id cannot be null.";
            //}
            await _leadAgentRepo.DeleteAsync(request.Id);
            return "Deleted Successfully";
        }
    }
}


