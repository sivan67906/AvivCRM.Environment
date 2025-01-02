using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.CreateProjectCategory;

internal class CreateProjectCategoryCommandHandler(
    IGenericRepository<ProjectCategory> projectCategoryRepository) : IRequestHandler<CreateProjectCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateProjectCategoryCommand request, CancellationToken cancellationToken)
    {
        var projectCategory = new ProjectCategory
        {
            Name = request.Name,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectCategoryRepository.CreateAsync(projectCategory);
    }
}












