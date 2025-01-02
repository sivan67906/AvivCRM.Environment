using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.UpdateProjectStatus;

internal class UpdateProjectStatusCommandHandler : IRequestHandler<UpdateProjectStatusCommand>
{
    private readonly IGenericRepository<Domain.Entities.ProjectStatus> _projectStatusRepository;

    public UpdateProjectStatusCommandHandler(
        IGenericRepository<Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;

    public async Task Handle(UpdateProjectStatusCommand request, CancellationToken cancellationToken)
    {

        if (request.IsDefaultStatus == true)
        {
            var projectStatusExistUpdate = await _projectStatusRepository.GetAllAsync();

            foreach (var entity in projectStatusExistUpdate)
            {
                if (entity.Id == request.Id)
                {
                    entity.Id = request.Id;
                    entity.Name = request.Name;
                    entity.ColorCode = request.ColorCode;
                    entity.IsDefaultStatus = request.IsDefaultStatus;
                    entity.Status = request.Status;
                    entity.UpdatedDate = DateTime.Now;
                    await _projectStatusRepository.UpdateAsync(entity);
                }
                else
                {
                    entity.IsDefaultStatus = false;
                    await _projectStatusRepository.UpdateAsync(entity);
                }
            }
        }
        else
        {
            var projectStatus = new Domain.Entities.ProjectStatus
            {
                Id = request.Id,
                Name = request.Name,
                ColorCode = request.ColorCode,
                IsDefaultStatus = request.IsDefaultStatus,
                Status = request.Status,
                UpdatedDate = DateTime.Now
            };

            await _projectStatusRepository.UpdateAsync(projectStatus);
        }





    }
}
















