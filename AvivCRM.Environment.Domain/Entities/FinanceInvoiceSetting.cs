using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class FinanceInvoiceSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string? FILogoPath { get; set; }
    public string? FILogoImageFileName { get; set; }
    public string? FIAuthorisedImagePath { get; set; }
    public string? FIAuthorisedImageFileName { get; set; }
    public int FILanguageId { get; set; }
    public int FIDueAfter { get; set; }
    public int FISendReminderBefore { get; set; }
    public int FISendReminderAfterEveryId { get; set; }
    public int FISendReminderAfterEvery { get; set; }
    public string? FICBGeneralJsonSettings { get; set; }
    public string? FICBClientInfoJsonSettings { get; set; }
    public string? FITerms { get; set; }
    public string? FIOtherInfo { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(FILanguageId))]
    public Language? Language { get; set; }
}




