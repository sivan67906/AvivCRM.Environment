using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class RecruitJobApplicationStatusSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public int JobApplicationPositionId { get; set; }
    public int JobApplicationCategoryId { get; set; }
    public string? JASStatus { get; set; }
    public string? JASColor { get; set; }
    public int JASIsModelChecked { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(JobApplicationPositionId))]
    public JobApplicationPosition? JobApplicationPosition { get; set; }

    [ForeignKey(nameof(JobApplicationCategoryId))]
    public JobApplicationCategory? JobApplicationCategory { get; set; }
}
