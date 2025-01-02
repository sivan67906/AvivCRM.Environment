namespace AvivCRM.Environment.Application.DTOs;
public class NotificationDTO
{
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
}





