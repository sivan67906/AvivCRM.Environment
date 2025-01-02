using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketTypes.GetAllTicketTypes;

internal class GetAllTicketTypesQueryHandler : IRequestHandler<GetAllTicketTypesQuery, IEnumerable<TicketTypeDTO>>
{
    private readonly IGenericRepository<TicketType> _ticketTypeRepository;

    public GetAllTicketTypesQueryHandler(
        IGenericRepository<TicketType> ticketTypeRepository)
    {
        _ticketTypeRepository = ticketTypeRepository;
    }

    public async Task<IEnumerable<TicketTypeDTO>> Handle(GetAllTicketTypesQuery request, CancellationToken cancellationToken)
    {
        var ticketTypes = await _ticketTypeRepository.GetAllAsync();
        var ticketTypeList = ticketTypes.Select(x => new TicketTypeDTO
        {
            Id = x.Id,
            TicketTypeCode = x.TicketTypeCode,
            TicketTypeName = x.TicketTypeName
        }).ToList();

        return ticketTypeList;
    }
}








































