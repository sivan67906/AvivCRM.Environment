using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class TimesheetSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public int ProjectId { get; set; }
    public int TaskId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime? StartDate { get; set; }
    public string? StartTime { get; set; }
    public string? StartDateTime { get; set; }
    public DateTime? EndDate { get; set; }
    public string? EndTime { get; set; }
    public string? EndDateTime { get; set; }
    public string? Memo { get; set; }
    public int TotalHours { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(ProjectId))]
    public ProjectSetting? projectSetting { get; set; }

    [ForeignKey(nameof(TaskId))]
    public Task? Task { get; set; }
    //[ForeignKey(nameof(EmployeeId))]
    //public Employee? employee { get; set; }
}












