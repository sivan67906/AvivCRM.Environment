using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketGroups.DeleteTicketGroup;

internal class DeleteTicketGroupCommandHandler : IRequestHandler<DeleteTicketGroupCommand>
{
    private readonly IGenericRepository<TicketGroup> _timeLogRepository;

    public DeleteTicketGroupCommandHandler(
        IGenericRepository<TicketGroup> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketGroupCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































