using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.CreateRecruitFooterSetting;

public class CreateRecruitFooterSettingCommand : IRequest
{
    public string? FooterTitle { get; set; }
    public string? FooterSlug { get; set; }
    public int FooterStatusId { get; set; }
    public string? FooterStatusName { get; set; }
    public string? FooterDescription { get; set; }
}
























