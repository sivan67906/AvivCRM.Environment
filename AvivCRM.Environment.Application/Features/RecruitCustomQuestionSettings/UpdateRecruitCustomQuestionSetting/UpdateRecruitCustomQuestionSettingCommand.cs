using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.UpdateRecruitCustomQuestionSetting;

public class UpdateRecruitCustomQuestionSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? CQQuestion { get; set; }
    public int CustomQuestionTypeId { get; set; }
    public int CustomQuestionCategoryId { get; set; }
    public int CQStatusId { get; set; }
    public int CQIsRequiredId { get; set; }
}
























