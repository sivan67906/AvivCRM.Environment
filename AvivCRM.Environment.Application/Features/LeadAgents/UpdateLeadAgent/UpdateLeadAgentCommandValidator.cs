﻿using FluentValidation;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.LeadAgents.UpdateLeadAgent;
public class UpdateLeadAgentCommandValidator : AbstractValidator<UpdateLeadAgentRequest>
{
    public UpdateLeadAgentCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Agent Id should not be empty");

        RuleFor(x => x.AgentName)
            .NotEmpty().WithMessage("Agent Name should not be empty")
            .MaximumLength(25).WithMessage("Agent Name must not exceed 25 Characters")
            .MinimumLength(3).WithMessage("Agent Name should not be less than 3 characters");
    }
}
