using MediatR;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.UpdateCustomQuestionCategory;

public class UpdateCustomQuestionCategoryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? CQCategoryCode { get; set; }
    public string? CQCategoryName { get; set; }
}
























