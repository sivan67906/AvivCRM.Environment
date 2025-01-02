using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.CreateProjectSetting;

internal class CreateProjectSettingCommandHandler(
    IGenericRepository<ProjectSetting> projectSettingRepository) : IRequestHandler<CreateProjectSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateProjectSettingCommand request, CancellationToken cancellationToken)
    {
        var projectSetting = new ProjectSetting
        {
            IsSendReminder = request.IsSendReminder,
            RemindBefore = request.RemindBefore,
            ProjectReminderPersonId = request.ProjectReminderPersonId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectSettingRepository.CreateAsync(projectSetting);
    }
}




















