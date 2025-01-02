using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Notifications.GetAllNotification;
public class GetAllNotificationQueryHandler : IRequestHandler<GetAllNotificationQuery, IEnumerable<NotificatonDTO>>
{
    private readonly IGenericRepository<Notification> _notifyrepo;
    public GetAllNotificationQueryHandler(IGenericRepository<Notification> notifyrepo)
    {
        _notifyrepo = notifyrepo;
    }

    public async Task<IEnumerable<NotificatonDTO>> Handle(GetAllNotificationQuery request, CancellationToken cancellationToken)
    {
        var clients = await _notifyrepo.GetAllAsync();

        var clientlist = clients.Select(x => new NotificatonDTO
        {
            Id = x.Id,
            ContractSigned = x.ContractSigned,
            EstimateDeclined = x.EstimateDeclined,
            EventInvite = x.EventInvite,
            ModulesEmailNotificationEventInviteNew = x.ModulesEmailNotificationEventInviteNew,
            RecurringExpenseStatusUpdated = x.RecurringExpenseStatusUpdated,
            NewExpenseAddedbyAdmin = x.NewExpenseAddedbyAdmin,
            NewExpenseAddedbyMember = x.NewExpenseAddedbyMember,
            Leadnotification = x.Leadnotification,
            NewOrder = x.NewOrder,
            OrderUpdated = x.OrderUpdated,
            NewProductPurchase = x.NewProductPurchase,
            NewNoticePublished = x.NewNoticePublished,
            UserJoinViaInvitation = x.UserJoinViaInvitation,
            NoticeUpdated = x.NoticeUpdated,
            UserRegistrationAddedbyAdmin = x.UserRegistrationAddedbyAdmin,
            ModulesEmailNotificationTestNotification = x.ModulesEmailNotificationTestNotification,
            TwoFactorCode = x.TwoFactorCode,

            // Leave

            NewLeaveApplication = x.NewLeaveApplication,
            NewLeaveRequest = x.NewLeaveRequest,
            LeaveApproved = x.LeaveApproved,
            LeaveRejected = x.LeaveRejected,
            LeaveUpdated = x.LeaveUpdated,
            MultipleLeaveApplication = x.MultipleLeaveApplication,

            // Proposal

            ProposalApproved = x.ProposalApproved,
            ProposalRejected = x.ProposalRejected,
            NewProposal = x.NewProposal,
            RecurringInvoiceStatusUpdated = x.RecurringInvoiceStatusUpdated,
            InvoiceReminder = x.InvoiceReminder,
            InvoiceCreated = x.InvoiceCreated,
            NewPropoInvoiceUpdatedsal = x.NewPropoInvoiceUpdatedsal,
            NewRecurringInvoice = x.NewRecurringInvoice,

            // Payment

            NewPayment = x.NewPayment,
            PaymentReceived = x.PaymentReceived,
            PaymentReminder = x.PaymentReminder,

            // Task

            NewTask = x.NewTask,
            TaskUpdated = x.TaskUpdated,
            TaskCompletedClient = x.TaskCompletedClient,
            TaskCompleted = x.TaskCompleted,
            NewClientTask = x.NewClientTask,
            TaskUpdateClient = x.TaskUpdateClient,
            SubTaskAssigneeAdded = x.SubTaskAssigneeAdded,
            SubTaskCompleted = x.SubTaskCompleted,
            TaskComment = x.TaskComment,
            TaskNote = x.TaskNote,
            TaskReminder = x.TaskReminder,
            AutoTaskReminder = x.AutoTaskReminder,

            // Ticket

            NewTicketRequest = x.NewTicketRequest,
            NewSupportTicketRequest = x.NewSupportTicketRequest,
            AgentTicket = x.AgentTicket,
            NewTicketReply = x.NewTicketReply,
            EmployeeAssigntoProject = x.EmployeeAssigntoProject,
            NewFileUploadedtoProject = x.NewFileUploadedtoProject,
            ProjectReminder = x.ProjectReminder,
            NewProject = x.NewProject,

            // Remainder

            AttendanceReminder = x.AttendanceReminder,
            FollowUpReminder = x.FollowUpReminder,
            EventReminder = x.EventReminder,
            ModulesEmailNotificationEventReminderNew = x.ModulesEmailNotificationEventReminderNew,
            ModulesEmailNotificationAttendanceReminderNew = x.ModulesEmailNotificationAttendanceReminderNew,

            // Removal Request

            RemovalRequestAdminNotification = x.RemovalRequestAdminNotification,
            RemovalRequestApproved = x.RemovalRequestApproved,
            RemovalRequestReject = x.RemovalRequestReject,
            RemovalRequestApprovedLead = x.RemovalRequestApprovedLead,
            RemovalRequestRejectLead = x.RemovalRequestRejectLead,
            RemovalRequestRejectUser = x.RemovalRequestRejectUser,
            RemovalRequestApprovedUser = x.RemovalRequestApprovedUser,

        }).ToList();

        return clientlist;
    }
}
