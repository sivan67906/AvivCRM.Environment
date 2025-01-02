using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketTypes.DeleteTicketType;

internal class DeleteTicketTypeCommandHandler : IRequestHandler<DeleteTicketTypeCommand>
{
    private readonly IGenericRepository<TicketType> _timeLogRepository;

    public DeleteTicketTypeCommandHandler(
        IGenericRepository<TicketType> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketTypeCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































