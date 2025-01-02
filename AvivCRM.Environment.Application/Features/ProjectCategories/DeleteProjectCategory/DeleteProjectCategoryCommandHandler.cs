using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.DeleteProjectCategory;

internal class DeleteProjectCategoryCommandHandler : IRequestHandler<DeleteProjectCategoryCommand>
{
    private readonly IGenericRepository<ProjectCategory> _projectCategoryRepository;

    public DeleteProjectCategoryCommandHandler(
        IGenericRepository<ProjectCategory> projectCategoryRepository) =>
        _projectCategoryRepository = projectCategoryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectCategoryCommand request, CancellationToken cancellationToken)
    {
        await _projectCategoryRepository.DeleteAsync(request.Id);
    }
}












