using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;
public class NotificationMain
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public string? CommonNotificationJson { get; set; }
    public string? LeaveNotificationJson { get; set; }
    public string? ProposalNotificationJson { get; set; }
    public string? InvoiceNotificationJson { get; set; }
    public string? PaymentNotificationJson { get; set; }
    public string? TaskNotificationJson { get; set; }
    public string? TicketNotificationJson { get; set; }
    public string? ProjectNotificationJson { get; set; }
    public string? ReminderNotificationJson { get; set; }
    public string? RequestNotificationJson { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}