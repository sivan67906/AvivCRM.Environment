//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.GetJobApplicationCategoryById
{
    public class GetJobApplicationCategoryByIdQuery : IRequest<JobApplicationCategoryDTO>
    {
        public Guid Id { get; set; }
    }
}
























