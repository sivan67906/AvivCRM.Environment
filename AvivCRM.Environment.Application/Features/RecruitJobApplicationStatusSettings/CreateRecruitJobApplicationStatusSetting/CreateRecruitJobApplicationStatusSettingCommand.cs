using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.CreateRecruitJobApplicationStatusSetting;

public class CreateRecruitJobApplicationStatusSettingCommand : IRequest
{
    public int JobApplicationPositionId { get; set; }
    public int JobApplicationCategoryId { get; set; }
    public string? JASStatus { get; set; }
    public string? JASColor { get; set; }
    public int JASIsModelChecked { get; set; }
}
























