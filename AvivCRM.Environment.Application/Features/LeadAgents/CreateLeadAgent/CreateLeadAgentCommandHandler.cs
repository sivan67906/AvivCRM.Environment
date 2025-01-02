using FluentValidation;
using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.LeadAgents.CreateLeadAgent
{
    public class CreateLeadAgentCommandHandler : IRequestHandler<CreateLeadAgentCommand, string>
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadagentRepository;
        private readonly IValidator<CreateLeadAgentRequest> _validator;
        public CreateLeadAgentCommandHandler(IGenericRepository<Domain.Entities.LeadAgent> leadagentRepository, IValidator<CreateLeadAgentRequest> validator)
        {
            _leadagentRepository = leadagentRepository;
            _validator = validator;
        }

        public async Task<string> Handle(CreateLeadAgentCommand request, CancellationToken cancellationToken)
        {

            var validate = await _validator.ValidateAsync(request.LeadAgent);
            if (!validate.IsValid)
            {
                var erroList = string.Join("; ", validate.Errors.Select(error => error.ErrorMessage));

                return erroList.ToString()!;
            }
            var leadAgent = new Domain.Entities.LeadAgent
            {
                AgentName = request.LeadAgent.AgentName
            };

            await _leadagentRepository.CreateAsync(leadAgent);
            return "Agent Created Successfully";
        }
    }
}


