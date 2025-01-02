using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketTypes.UpdateTicketType;

internal class UpdateTicketTypeCommandHandler : IRequestHandler<UpdateTicketTypeCommand>
{
    private readonly IGenericRepository<TicketType> _ticketTypeRepository;

    public UpdateTicketTypeCommandHandler(
        IGenericRepository<TicketType> ticketTypeRepository) =>
        _ticketTypeRepository = ticketTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketTypeCommand request, CancellationToken cancellationToken)
    {
        var ticketType = new TicketType
        {
            Id = request.Id,
            TicketTypeCode = request.TicketTypeCode,
            TicketTypeName = request.TicketTypeName,
            UpdatedDate = DateTime.Now
        };

        await _ticketTypeRepository.UpdateAsync(ticketType);
    }
}








































