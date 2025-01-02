using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.DeleteRecruitFooterSetting
{
    public class DeleteRecruitFooterSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























