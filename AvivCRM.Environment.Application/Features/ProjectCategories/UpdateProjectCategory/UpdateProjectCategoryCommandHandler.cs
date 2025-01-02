using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.UpdateProjectCategory;

internal class UpdateProjectCategoryCommandHandler : IRequestHandler<UpdateProjectCategoryCommand>
{
    private readonly IGenericRepository<ProjectCategory> _projectCategoryRepository;

    public UpdateProjectCategoryCommandHandler(
        IGenericRepository<ProjectCategory> projectCategoryRepository) =>
        _projectCategoryRepository = projectCategoryRepository;

    public async System.Threading.Tasks.Task Handle(UpdateProjectCategoryCommand request, CancellationToken cancellationToken)
    {
        var projectCategory = new ProjectCategory
        {
            Id = request.Id,
            Name = request.Name,
            UpdatedDate = DateTime.Now
        };

        await _projectCategoryRepository.UpdateAsync(projectCategory);
    }
}












