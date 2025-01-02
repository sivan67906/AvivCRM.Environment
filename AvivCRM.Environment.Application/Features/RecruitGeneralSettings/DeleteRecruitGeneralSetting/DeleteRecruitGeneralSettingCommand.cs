using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitGeneralSettings.DeleteRecruitGeneralSetting
{
    public class DeleteRecruitGeneralSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























