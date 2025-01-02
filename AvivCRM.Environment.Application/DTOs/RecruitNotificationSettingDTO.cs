namespace AvivCRM.Environment.Application.DTOs;
public class RecruitNotificationSettingDTO
{
    public Guid Id { get; set; }
    public string? CBEMailJsonSettings { get; set; }
    public string? CBEMailNotificationJsonSettings { get; set; }
}