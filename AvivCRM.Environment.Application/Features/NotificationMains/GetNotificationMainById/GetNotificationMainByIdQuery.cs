//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.NotificationMains.GetNotificationMainById
{
    public class GetNotificationMainByIdQuery : IRequest<NotificationMainDTO>
    {
        public Guid Id { get; set; }
    }
}

































