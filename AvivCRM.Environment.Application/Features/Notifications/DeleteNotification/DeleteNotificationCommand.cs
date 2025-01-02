using MediatR;

namespace AvivCRM.Environment.Application.Features.Notifications.DeleteNotification;
public class DeleteNotificationCommand : IRequest
{
    public Guid Id { get; set; }
}
