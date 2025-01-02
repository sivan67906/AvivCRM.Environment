using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Notifications.GetByIdNotificaton;
public class GetNotificationByIdQueryHandler : IRequestHandler<GetNotificationByIdQuery, NotificatonDTO>
{
    private readonly IGenericRepository<Notification> _repository;
    public GetNotificationByIdQueryHandler(IGenericRepository<Notification> repository)
    {
        _repository = repository;
    }

    public async Task<NotificatonDTO> Handle(GetNotificationByIdQuery request, CancellationToken cancellationToken)
    {
        var notification = await _repository.GetByIdAsync(request.Id);
        if (notification == null) return null;
        return new NotificatonDTO
        {
            Id = notification.Id,
            ContractSigned = notification.ContractSigned,
            EstimateDeclined = notification.EstimateDeclined,
            EventInvite = notification.EventInvite,
            ModulesEmailNotificationEventInviteNew = notification.ModulesEmailNotificationEventInviteNew,
            RecurringExpenseStatusUpdated = notification.RecurringExpenseStatusUpdated,
            NewExpenseAddedbyAdmin = notification.NewExpenseAddedbyAdmin,
            NewExpenseAddedbyMember = notification.NewExpenseAddedbyMember,
            Leadnotification = notification.Leadnotification,
            NewOrder = notification.NewOrder,
            OrderUpdated = notification.OrderUpdated,
            NewProductPurchase = notification.NewProductPurchase,
            NewNoticePublished = notification.NewNoticePublished,
            UserJoinViaInvitation = notification.UserJoinViaInvitation,
            NoticeUpdated = notification.NoticeUpdated,
            UserRegistrationAddedbyAdmin = notification.UserRegistrationAddedbyAdmin,
            ModulesEmailNotificationTestNotification = notification.ModulesEmailNotificationTestNotification,
            TwoFactorCode = notification.TwoFactorCode,

            // Leave

            NewLeaveApplication = notification.NewLeaveApplication,
            NewLeaveRequest = notification.NewLeaveRequest,
            LeaveApproved = notification.LeaveApproved,
            LeaveRejected = notification.LeaveRejected,
            LeaveUpdated = notification.LeaveUpdated,
            MultipleLeaveApplication = notification.MultipleLeaveApplication,

            // Proposal

            ProposalApproved = notification.ProposalApproved,
            ProposalRejected = notification.ProposalRejected,
            NewProposal = notification.NewProposal,
            RecurringInvoiceStatusUpdated = notification.RecurringInvoiceStatusUpdated,
            InvoiceReminder = notification.InvoiceReminder,
            InvoiceCreated = notification.InvoiceCreated,
            NewPropoInvoiceUpdatedsal = notification.NewPropoInvoiceUpdatedsal,
            NewRecurringInvoice = notification.NewRecurringInvoice,

            // Payment

            NewPayment = notification.NewPayment,
            PaymentReceived = notification.PaymentReceived,
            PaymentReminder = notification.PaymentReminder,

            // Task

            NewTask = notification.NewTask,
            TaskUpdated = notification.TaskUpdated,
            TaskCompletedClient = notification.TaskCompletedClient,
            TaskCompleted = notification.TaskCompleted,
            NewClientTask = notification.NewClientTask,
            TaskUpdateClient = notification.TaskUpdateClient,
            SubTaskAssigneeAdded = notification.SubTaskAssigneeAdded,
            SubTaskCompleted = notification.SubTaskCompleted,
            TaskComment = notification.TaskComment,
            TaskNote = notification.TaskNote,
            TaskReminder = notification.TaskReminder,
            AutoTaskReminder = notification.AutoTaskReminder,

            // Ticket

            NewTicketRequest = notification.NewTicketRequest,
            NewSupportTicketRequest = notification.NewSupportTicketRequest,
            AgentTicket = notification.AgentTicket,
            NewTicketReply = notification.NewTicketReply,
            EmployeeAssigntoProject = notification.EmployeeAssigntoProject,
            NewFileUploadedtoProject = notification.NewFileUploadedtoProject,
            ProjectReminder = notification.ProjectReminder,
            NewProject = notification.NewProject,

            // Remainder

            AttendanceReminder = notification.AttendanceReminder,
            FollowUpReminder = notification.FollowUpReminder,
            EventReminder = notification.EventReminder,
            ModulesEmailNotificationEventReminderNew = notification.ModulesEmailNotificationEventReminderNew,
            ModulesEmailNotificationAttendanceReminderNew = notification.ModulesEmailNotificationAttendanceReminderNew,

            // Removal Request

            RemovalRequestAdminNotification = notification.RemovalRequestAdminNotification,
            RemovalRequestApproved = notification.RemovalRequestApproved,
            RemovalRequestReject = notification.RemovalRequestReject,
            RemovalRequestApprovedLead = notification.RemovalRequestApprovedLead,
            RemovalRequestRejectLead = notification.RemovalRequestRejectLead,
            RemovalRequestRejectUser = notification.RemovalRequestRejectUser,
            RemovalRequestApprovedUser = notification.RemovalRequestApprovedUser,

        };
    }
}
