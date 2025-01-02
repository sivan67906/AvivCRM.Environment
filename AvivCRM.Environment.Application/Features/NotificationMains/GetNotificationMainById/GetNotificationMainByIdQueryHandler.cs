using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.NotificationMains.GetNotificationMainById;

internal class GetNotificationMainByIdQueryHandler : IRequestHandler<GetNotificationMainByIdQuery, NotificationMainDTO>
{
    private readonly IGenericRepository<NotificationMain> _notificationMainRepository;

    public GetNotificationMainByIdQueryHandler(
        IGenericRepository<NotificationMain> notificationMainRepository) =>
        _notificationMainRepository = notificationMainRepository;

    public async Task<NotificationMainDTO> Handle(GetNotificationMainByIdQuery request, CancellationToken cancellationToken)
    {
        var notificationMain = await _notificationMainRepository.GetByIdAsync(request.Id);
        if (notificationMain == null) return null;
        return new NotificationMainDTO
        {
            Id = notificationMain.Id,
            CommonNotificationMainJson = notificationMain.CommonNotificationJson,
            LeaveNotificationMainJson = notificationMain.LeaveNotificationJson,
            ProposalNotificationMainJson = notificationMain.ProposalNotificationJson,
            InvoiceNotificationMainJson = notificationMain.InvoiceNotificationJson,
            PaymentNotificationMainJson = notificationMain.PaymentNotificationJson,
            TaskNotificationMainJson = notificationMain.TaskNotificationJson,
            TicketNotificationMainJson = notificationMain.TicketNotificationJson,
            ProjectNotificationMainJson = notificationMain.ProjectNotificationJson,
            ReminderNotificationMainJson = notificationMain.ReminderNotificationJson,
            RequestNotificationMainJson = notificationMain.RequestNotificationJson
        };
    }
}

































