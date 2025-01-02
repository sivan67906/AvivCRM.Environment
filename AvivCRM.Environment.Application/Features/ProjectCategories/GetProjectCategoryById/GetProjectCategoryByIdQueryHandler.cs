using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.GetProjectCategoryById;

internal class GetProjectCategoryByIdQueryHandler : IRequestHandler<GetProjectCategoryByIdQuery, ProjectCategoryDTO>
{
    private readonly IGenericRepository<ProjectCategory> _projectCategoryRepository;

    public GetProjectCategoryByIdQueryHandler(
        IGenericRepository<ProjectCategory> projectCategoryRepository) =>
        _projectCategoryRepository = projectCategoryRepository;

    public async Task<ProjectCategoryDTO> Handle(GetProjectCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var projectCategory = await _projectCategoryRepository.GetByIdAsync(request.Id);
        if (projectCategory == null) return null;
        return new ProjectCategoryDTO
        {
            Id = projectCategory.Id,
            Name = projectCategory.Name
        };
    }
}












