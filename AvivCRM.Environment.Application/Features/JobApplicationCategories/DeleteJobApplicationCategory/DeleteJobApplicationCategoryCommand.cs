using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.DeleteJobApplicationCategory
{
    public class DeleteJobApplicationCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























