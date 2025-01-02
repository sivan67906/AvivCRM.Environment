namespace AvivCRM.Environment.Application.DTOs;
public class RecruiterSettingDTO
{
    public Guid Id { get; set; }
    public string? RecruiterName { get; set; }
    public int RecruiterStatusId { get; set; }
    public string? RecruiterStatusName { get; set; }
}