using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Notifications.GetByIdNotificaton;
public class GetNotificationByIdQuery : IRequest<NotificatonDTO>
{
    public Guid Id { get; set; }
}
