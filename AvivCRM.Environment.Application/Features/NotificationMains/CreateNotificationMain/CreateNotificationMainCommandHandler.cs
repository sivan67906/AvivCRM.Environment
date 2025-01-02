using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.NotificationMains.CreateNotificationMain;

internal class CreateNotificationMainCommandHandler(
    IGenericRepository<NotificationMain> notificationMainRepository) : IRequestHandler<CreateNotificationMainCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateNotificationMainCommand request, CancellationToken cancellationToken)
    {
        var notificationMain = new NotificationMain
        {
            CommonNotificationJson = request.CommonNotificationMainJson,
            LeaveNotificationJson = request.LeaveNotificationMainJson,
            ProposalNotificationJson = request.ProposalNotificationMainJson,
            InvoiceNotificationJson = request.InvoiceNotificationMainJson,
            PaymentNotificationJson = request.PaymentNotificationMainJson,
            TaskNotificationJson = request.TaskNotificationMainJson,
            TicketNotificationJson = request.TicketNotificationMainJson,
            ProjectNotificationJson = request.ProposalNotificationMainJson,
            ReminderNotificationJson = request.RequestNotificationMainJson,
            RequestNotificationJson = request.RequestNotificationMainJson,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await notificationMainRepository.CreateAsync(notificationMain);
    }
}

































