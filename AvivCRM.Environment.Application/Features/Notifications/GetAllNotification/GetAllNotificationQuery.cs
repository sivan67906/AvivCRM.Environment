using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Notifications.GetAllNotification;
public class GetAllNotificationQuery : IRequest<IEnumerable<NotificatonDTO>>
{
}
