using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketGroups.GetTicketGroupById;

internal class GetTicketGroupByIdQueryHandler : IRequestHandler<GetTicketGroupByIdQuery, TicketGroupDTO>
{
    private readonly IGenericRepository<TicketGroup> _ticketGroupRepository;

    public GetTicketGroupByIdQueryHandler(
        IGenericRepository<TicketGroup> ticketGroupRepository) =>
        _ticketGroupRepository = ticketGroupRepository;

    public async Task<TicketGroupDTO> Handle(GetTicketGroupByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketGroup = await _ticketGroupRepository.GetByIdAsync(request.Id);
        if (ticketGroup == null) return null;
        return new TicketGroupDTO
        {
            Id = ticketGroup.Id,
            TicketGroupCode = ticketGroup.TicketGroupCode,
            TicketGroupName = ticketGroup.TicketGroupName
        };
    }
}








































