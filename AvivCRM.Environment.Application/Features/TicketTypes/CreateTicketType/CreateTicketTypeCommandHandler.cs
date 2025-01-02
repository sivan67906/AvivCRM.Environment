using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketTypes.CreateTicketType;

internal class CreateTicketTypeCommandHandler(
    IGenericRepository<TicketType> ticketTypeRepository) : IRequestHandler<CreateTicketTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketTypeCommand request, CancellationToken cancellationToken)
    {
        var ticketType = new TicketType
        {
            TicketTypeCode = request.TicketTypeCode,
            TicketTypeName = request.TicketTypeName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketTypeRepository.CreateAsync(ticketType);
    }
}








































