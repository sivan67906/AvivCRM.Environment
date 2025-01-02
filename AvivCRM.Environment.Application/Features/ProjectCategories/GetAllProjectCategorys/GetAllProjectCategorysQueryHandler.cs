using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.GetAllProjectCategorys;

internal class GetAllProjectCategoriesQueryHandler : IRequestHandler<GetAllProjectCategoriesQuery, IEnumerable<ProjectCategoryDTO>>
{
    private readonly IGenericRepository<ProjectCategory> _projectCategoryRepository;

    public GetAllProjectCategoriesQueryHandler(
        IGenericRepository<ProjectCategory> projectCategoryRepository) =>
        _projectCategoryRepository = projectCategoryRepository;

    public async Task<IEnumerable<ProjectCategoryDTO>> Handle(GetAllProjectCategoriesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _projectCategoryRepository.GetAllAsync();

        var projectCategoryList = companies.Select(x => new ProjectCategoryDTO
        {
            Id = x.Id,
            Name = x.Name
        }).ToList();

        return projectCategoryList;
    }
}












