using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketAgents.GetAllTicketAgents;

internal class GetAllTicketAgentsQueryHandler : IRequestHandler<GetAllTicketAgentsQuery, IEnumerable<TicketAgentDTO>>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public GetAllTicketAgentsQueryHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository)
    {
        _ticketAgentRepository = ticketAgentRepository;
    }

    public async Task<IEnumerable<TicketAgentDTO>> Handle(GetAllTicketAgentsQuery request, CancellationToken cancellationToken)
    {
        var ticketAgents = await _ticketAgentRepository.GetAllAsync();
        var ticketAgentList = ticketAgents.Select(x => new TicketAgentDTO
        {
            Id = x.Id,
            TicketAgentCode = x.TicketAgentCode,
            TicketAgentName = x.TicketAgentName
        }).ToList();

        return ticketAgentList;
    }
}














































