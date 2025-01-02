using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.DeleteProjectSetting
{
    public class DeleteProjectSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




















