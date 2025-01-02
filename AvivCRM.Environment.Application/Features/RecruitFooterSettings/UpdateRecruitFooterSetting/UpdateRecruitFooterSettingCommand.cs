using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.UpdateRecruitFooterSetting;

public class UpdateRecruitFooterSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FooterTitle { get; set; }
    public string? FooterSlug { get; set; }
    public int FooterStatusId { get; set; }
    public string? FooterDescription { get; set; }
}
























