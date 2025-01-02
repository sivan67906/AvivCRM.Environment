using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimeLogs.DeleteTimeLog;

internal class DeleteTimeLogCommandHandler : IRequestHandler<DeleteTimeLogCommand>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;

    public DeleteTimeLogCommandHandler(
        IGenericRepository<TimeLog> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTimeLogCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}




























