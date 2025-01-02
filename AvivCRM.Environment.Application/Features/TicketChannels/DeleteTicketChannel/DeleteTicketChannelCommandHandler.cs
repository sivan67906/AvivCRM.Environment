using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketChannels.DeleteTicketChannel;

internal class DeleteTicketChannelCommandHandler : IRequestHandler<DeleteTicketChannelCommand>
{
    private readonly IGenericRepository<TicketChannel> _timeLogRepository;

    public DeleteTicketChannelCommandHandler(
        IGenericRepository<TicketChannel> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketChannelCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































