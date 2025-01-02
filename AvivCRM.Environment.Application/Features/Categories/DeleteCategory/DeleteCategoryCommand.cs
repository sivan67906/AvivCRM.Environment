using MediatR;

namespace AvivCRM.Environment.Application.Features.Categories.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}









