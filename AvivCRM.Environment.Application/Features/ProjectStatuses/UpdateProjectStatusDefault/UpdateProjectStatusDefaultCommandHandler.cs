using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.UpdateProjectStatusDefault;
internal class UpdateProjectStatusDefaultCommandHandler : IRequestHandler<UpdateProjectStatusDefaultCommand>
{
    private readonly IGenericRepository<Domain.Entities.ProjectStatus> _projectStatusRepository;

    public UpdateProjectStatusDefaultCommandHandler(
        IGenericRepository<Domain.Entities.ProjectStatus> projectStatusRepository)
    {
        _projectStatusRepository = projectStatusRepository;
    }

    public async Task Handle(UpdateProjectStatusDefaultCommand request, CancellationToken cancellationToken)
    {
        //var projectStatus = await _projectStatusRepository.GetByIdAsync(request.Id);
        var projectStatus = await _projectStatusRepository.GetAllAsync();

        foreach (var entity in projectStatus)
        {
            if (entity.Id == request.Id)
            {
                entity.Id = request.Id;
                entity.IsDefaultStatus = true;
                entity.UpdatedDate = DateTime.Now;
                await _projectStatusRepository.UpdateAsync(entity);
            }
            else
            {
                entity.IsDefaultStatus = false;
                await _projectStatusRepository.UpdateAsync(entity);
            }
        }
        //var projectStatusUpdate = new AvivCRM.Environment.Domain.Entities.ProjectStatuses
        //{
        //    Id = projectStatus.Id,
        //    IsDefaultStatus = true,
        //    UpdatedDate = DateTime.Now
        //};
    }
}
