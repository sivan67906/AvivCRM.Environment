using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class RecruitGeneralSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string? GeneralCompanyName { get; set; }
    public string? GeneralCompanyWebsite { get; set; }
    public string? GeneralCompanyLogo { get; set; }
    public string? GeneralCompanyLogoPath { get; set; }
    public string? GeneralCompanyLogoImageFileName { get; set; }
    public string? GeneralAboutCompany { get; set; }
    public string? GeneralLegalTerm { get; set; }
    public int GeneralDuplJobApplnRestrictDays { get; set; }
    public int GeneralOLReminderToCandidate { get; set; }
    public string? GeneralBGLogo { get; set; }
    public string? GeneralBGLogoPath { get; set; }
    public string? GeneralBGLogoImageFileName { get; set; }
    public string? GeneralBGColorCode { get; set; }
    //public string? GeneralRBJsonSettings { get; set; }
    public string? GeneralCBJsonSettings { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}
