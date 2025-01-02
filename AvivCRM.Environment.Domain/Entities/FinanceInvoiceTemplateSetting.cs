using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public sealed class FinanceInvoiceTemplateSetting
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string? FIRBTemplateJsonSettings { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}




