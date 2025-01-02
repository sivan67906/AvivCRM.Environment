using MediatR;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.CreateCustomQuestionCategory;

public class CreateCustomQuestionCategoryCommand : IRequest
{
    public string? CQCategoryCode { get; set; }
    public string? CQCategoryName { get; set; }
}
























