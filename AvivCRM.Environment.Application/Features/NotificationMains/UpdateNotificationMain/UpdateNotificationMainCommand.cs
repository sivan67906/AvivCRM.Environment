using MediatR;

namespace AvivCRM.Environment.Application.Features.NotificationMains.UpdateNotificationMain;

public class UpdateNotificationMainCommand : IRequest
{
    public Guid Id { get; set; }
    public string? CommonNotificationMainJson { get; set; }
    public string? LeaveNotificationMainJson { get; set; }
    public string? ProposalNotificationMainJson { get; set; }
    public string? InvoiceNotificationMainJson { get; set; }
    public string? PaymentNotificationMainJson { get; set; }
    public string? TaskNotificationMainJson { get; set; }
    public string? TicketNotificationMainJson { get; set; }
    public string? ProjectNotificationMainJson { get; set; }
    public string? ReminderNotificationMainJson { get; set; }
    public string? RequestNotificationMainJson { get; set; }
}
































