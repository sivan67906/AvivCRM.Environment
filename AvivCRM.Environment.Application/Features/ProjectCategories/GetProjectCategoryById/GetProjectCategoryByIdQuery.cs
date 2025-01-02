using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.GetProjectCategoryById
{
    public class GetProjectCategoryByIdQuery : IRequest<ProjectCategoryDTO>
    {
        public Guid Id { get; set; }
    }
}












