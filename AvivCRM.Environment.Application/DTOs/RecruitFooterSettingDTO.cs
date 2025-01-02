namespace AvivCRM.Environment.Application.DTOs;
public class RecruitFooterSettingDTO
{
    public Guid Id { get; set; }
    public string? FooterTitle { get; set; }
    public string? FooterSlug { get; set; }
    public int FooterStatusId { get; set; }
    public string? FooterStatusName { get; set; }
    public string? FooterDescription { get; set; }
}