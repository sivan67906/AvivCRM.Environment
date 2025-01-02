using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.DeleteProjectSetting;

internal class DeleteProjectSettingCommandHandler : IRequestHandler<DeleteProjectSettingCommand>
{
    private readonly IGenericRepository<ProjectSetting> _projectSettingRepository;

    public DeleteProjectSettingCommandHandler(
        IGenericRepository<ProjectSetting> projectSettingRepository) =>
        _projectSettingRepository = projectSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectSettingCommand request, CancellationToken cancellationToken)
    {
        await _projectSettingRepository.DeleteAsync(request.Id);
    }
}




















