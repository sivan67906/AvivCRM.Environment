using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketAgents.GetTicketAgentById;

internal class GetTicketAgentByIdQueryHandler : IRequestHandler<GetTicketAgentByIdQuery, TicketAgentDTO>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public GetTicketAgentByIdQueryHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository) =>
        _ticketAgentRepository = ticketAgentRepository;

    public async Task<TicketAgentDTO> Handle(GetTicketAgentByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketAgent = await _ticketAgentRepository.GetByIdAsync(request.Id);
        if (ticketAgent == null) return null;
        return new TicketAgentDTO
        {
            Id = ticketAgent.Id,
            TicketAgentCode = ticketAgent.TicketAgentCode,
            TicketAgentName = ticketAgent.TicketAgentName
        };
    }
}














































