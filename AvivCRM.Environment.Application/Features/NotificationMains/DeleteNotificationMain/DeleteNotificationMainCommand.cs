using MediatR;

namespace AvivCRM.Environment.Application.Features.NotificationMains.DeleteNotificationMain
{
    public class DeleteNotificationMainCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

































