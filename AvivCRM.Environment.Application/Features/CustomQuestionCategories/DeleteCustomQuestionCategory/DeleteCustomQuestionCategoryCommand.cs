using MediatR;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.DeleteCustomQuestionCategory
{
    public class DeleteCustomQuestionCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























