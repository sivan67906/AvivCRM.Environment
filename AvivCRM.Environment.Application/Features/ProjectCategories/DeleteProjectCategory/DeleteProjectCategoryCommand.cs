using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.DeleteProjectCategory
{
    public class DeleteProjectCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}












