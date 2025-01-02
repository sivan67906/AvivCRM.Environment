using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Notifications.DeleteNotification;
public class DeleteNotificationCommandHandler : IRequestHandler<DeleteNotificationCommand>
{
    private readonly IGenericRepository<Notification> _repository;
    public DeleteNotificationCommandHandler(IGenericRepository<Notification> repository)
    {
        _repository = repository;
    }

    public async System.Threading.Tasks.Task Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}
