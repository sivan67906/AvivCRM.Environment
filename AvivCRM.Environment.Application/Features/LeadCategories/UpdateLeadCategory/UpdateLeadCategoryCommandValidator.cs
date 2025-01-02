using FluentValidation;
using AvivCRM.Environment.Application.DTOs.LeadCategories;

namespace AvivCRM.Environment.Application.Features.LeadCategories.UpdateLeadCategory;

public class UpdateLeadCategoryCommandValidator : AbstractValidator<UpdateLeadCategoryRequest>
{
    public UpdateLeadCategoryCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Categories Id should not be empty");

        RuleFor(x => x.CategoryName)
            .NotEmpty().WithMessage("Categories Name should not be empty")
            .MaximumLength(25).WithMessage("Categories Name must not exceed 25 Characters")
            .MinimumLength(3).WithMessage("Categories Name should not be less than 3 characters");

    }
}


