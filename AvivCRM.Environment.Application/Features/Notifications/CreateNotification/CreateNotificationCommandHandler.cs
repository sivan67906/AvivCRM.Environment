using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Notifications.CreateNotification;
public class CreateNotificationCommandHandler : IRequestHandler<CreateNotificationCommand, Guid>
{
    private readonly IGenericRepository<Notification> _notifyrepo;
    public CreateNotificationCommandHandler(IGenericRepository<Notification> notifyrepo) => _notifyrepo = notifyrepo;

    public async Task<Guid> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
    {
        var client = new Notification
        {
            ContractSigned = request.ContractSigned,
            EstimateDeclined = request.EstimateDeclined,
            EventInvite = request.EventInvite,
            ModulesEmailNotificationEventInviteNew = request.ModulesEmailNotificationEventInviteNew,
            RecurringExpenseStatusUpdated = request.RecurringExpenseStatusUpdated,
            NewExpenseAddedbyAdmin = request.NewExpenseAddedbyAdmin,
            NewExpenseAddedbyMember = request.NewExpenseAddedbyMember,
            Leadnotification = request.Leadnotification,
            NewOrder = request.NewOrder,
            OrderUpdated = request.OrderUpdated,
            NewProductPurchase = request.NewProductPurchase,
            NewNoticePublished = request.NewNoticePublished,
            UserJoinViaInvitation = request.UserJoinViaInvitation,
            NoticeUpdated = request.NoticeUpdated,
            UserRegistrationAddedbyAdmin = request.UserRegistrationAddedbyAdmin,
            ModulesEmailNotificationTestNotification = request.ModulesEmailNotificationTestNotification,
            TwoFactorCode = request.TwoFactorCode,

            // Leave

            NewLeaveApplication = request.NewLeaveApplication,
            NewLeaveRequest = request.NewLeaveRequest,
            LeaveApproved = request.LeaveApproved,
            LeaveRejected = request.LeaveRejected,
            LeaveUpdated = request.LeaveUpdated,
            MultipleLeaveApplication = request.MultipleLeaveApplication,

            // Proposal

            ProposalApproved = request.ProposalApproved,
            ProposalRejected = request.ProposalRejected,
            NewProposal = request.NewProposal,
            RecurringInvoiceStatusUpdated = request.RecurringInvoiceStatusUpdated,
            InvoiceReminder = request.InvoiceReminder,
            InvoiceCreated = request.InvoiceCreated,
            NewPropoInvoiceUpdatedsal = request.NewPropoInvoiceUpdatedsal,
            NewRecurringInvoice = request.NewRecurringInvoice,

            // Payment

            NewPayment = request.NewPayment,
            PaymentReceived = request.PaymentReceived,
            PaymentReminder = request.PaymentReminder,

            // Task

            NewTask = request.NewTask,
            TaskUpdated = request.TaskUpdated,
            TaskCompletedClient = request.TaskCompletedClient,
            TaskCompleted = request.TaskCompleted,
            NewClientTask = request.NewClientTask,
            TaskUpdateClient = request.TaskUpdateClient,
            SubTaskAssigneeAdded = request.SubTaskAssigneeAdded,
            SubTaskCompleted = request.SubTaskCompleted,
            TaskComment = request.TaskComment,
            TaskNote = request.TaskNote,
            TaskReminder = request.TaskReminder,
            AutoTaskReminder = request.AutoTaskReminder,

            // Ticket

            NewTicketRequest = request.NewTicketRequest,
            NewSupportTicketRequest = request.NewSupportTicketRequest,
            AgentTicket = request.AgentTicket,
            NewTicketReply = request.NewTicketReply,
            EmployeeAssigntoProject = request.EmployeeAssigntoProject,
            NewFileUploadedtoProject = request.NewFileUploadedtoProject,
            ProjectReminder = request.ProjectReminder,
            NewProject = request.NewProject,

            // Remainder

            AttendanceReminder = request.AttendanceReminder,
            FollowUpReminder = request.FollowUpReminder,
            EventReminder = request.EventReminder,
            ModulesEmailNotificationEventReminderNew = request.ModulesEmailNotificationEventReminderNew,
            ModulesEmailNotificationAttendanceReminderNew = request.ModulesEmailNotificationAttendanceReminderNew,

            // Removal Request

            RemovalRequestAdminNotification = request.RemovalRequestAdminNotification,
            RemovalRequestApproved = request.RemovalRequestApproved,
            RemovalRequestReject = request.RemovalRequestReject,
            RemovalRequestApprovedLead = request.RemovalRequestApprovedLead,
            RemovalRequestRejectLead = request.RemovalRequestRejectLead,
            RemovalRequestRejectUser = request.RemovalRequestRejectUser,
            RemovalRequestApprovedUser = request.RemovalRequestApprovedUser,
        };
        await _notifyrepo.CreateAsync(client);
        return client.Id;
    }
}
