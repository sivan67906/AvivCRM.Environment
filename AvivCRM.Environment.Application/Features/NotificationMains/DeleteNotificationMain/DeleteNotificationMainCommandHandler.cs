using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.NotificationMains.DeleteNotificationMain;

internal class DeleteNotificationMainCommandHandler : IRequestHandler<DeleteNotificationMainCommand>
{
    private readonly IGenericRepository<NotificationMain> _notificationMainRepository;

    public DeleteNotificationMainCommandHandler(
        IGenericRepository<NotificationMain> notificationMainRepository) =>
        _notificationMainRepository = notificationMainRepository;
    public async System.Threading.Tasks.Task Handle(DeleteNotificationMainCommand request, CancellationToken cancellationToken)
    {
        await _notificationMainRepository.DeleteAsync(request.Id);
    }
}

































