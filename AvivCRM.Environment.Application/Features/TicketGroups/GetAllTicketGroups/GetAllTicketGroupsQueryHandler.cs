using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketGroups.GetAllTicketGroups;

internal class GetAllTicketGroupsQueryHandler : IRequestHandler<GetAllTicketGroupsQuery, IEnumerable<TicketGroupDTO>>
{
    private readonly IGenericRepository<TicketGroup> _ticketGroupRepository;

    public GetAllTicketGroupsQueryHandler(
        IGenericRepository<TicketGroup> ticketGroupRepository)
    {
        _ticketGroupRepository = ticketGroupRepository;
    }

    public async Task<IEnumerable<TicketGroupDTO>> Handle(GetAllTicketGroupsQuery request, CancellationToken cancellationToken)
    {
        var ticketGroups = await _ticketGroupRepository.GetAllAsync();
        var ticketGroupList = ticketGroups.Select(x => new TicketGroupDTO
        {
            Id = x.Id,
            TicketGroupCode = x.TicketGroupCode,
            TicketGroupName = x.TicketGroupName
        }).ToList();

        return ticketGroupList;
    }
}








































