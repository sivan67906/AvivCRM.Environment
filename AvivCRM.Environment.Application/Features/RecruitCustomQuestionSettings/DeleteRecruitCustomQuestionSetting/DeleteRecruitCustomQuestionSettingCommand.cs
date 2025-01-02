using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.DeleteRecruitCustomQuestionSetting
{
    public class DeleteRecruitCustomQuestionSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























