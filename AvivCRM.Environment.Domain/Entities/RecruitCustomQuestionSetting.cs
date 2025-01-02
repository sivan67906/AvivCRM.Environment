using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class RecruitCustomQuestionSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string? CQQuestion { get; set; }
    public int CustomQuestionTypeId { get; set; }
    public int CustomQuestionCategoryId { get; set; }
    public int CQStatusId { get; set; }
    public int CQIsRequiredId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;


    [ForeignKey(nameof(CustomQuestionTypeId))]
    public CustomQuestionType? CustomQuestionType { get; set; }

    [ForeignKey(nameof(CustomQuestionCategoryId))]
    public CustomQuestionCategory? CustomQuestionCategory { get; set; }
}
