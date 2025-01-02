using FluentValidation;
using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.LeadAgents.UpdateLeadAgent
{
    public class UpdateLeadAgentCommandHandler : IRequestHandler<UpdateLeadAgentCommand, string>
    {

        private readonly IGenericRepository<Domain.Entities.LeadAgent> _repository;
        private readonly IValidator<UpdateLeadAgentRequest> _validator;
        public UpdateLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> repository
            , IValidator<UpdateLeadAgentRequest> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public async Task<string> Handle(UpdateLeadAgentCommand request, CancellationToken cancellationToken)
        {
            var validate = await _validator.ValidateAsync(request.LeadAgent);
            if (!validate.IsValid)
            {
                var erroList = string.Join("; ", validate.Errors.Select(error => error.ErrorMessage));

                return erroList.ToString()!;
            }
            var leadAgent = new Domain.Entities.LeadAgent
            {
                Id = request.LeadAgent.Id,
                AgentName = request.LeadAgent.AgentName
            };
            await _repository.UpdateAsync(leadAgent);
            return "Updated Successfully";
        }
    }
}


