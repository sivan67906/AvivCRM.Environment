using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketAgents.UpdateTicketAgent;

internal class UpdateTicketAgentCommandHandler : IRequestHandler<UpdateTicketAgentCommand>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public UpdateTicketAgentCommandHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository) =>
        _ticketAgentRepository = ticketAgentRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketAgentCommand request, CancellationToken cancellationToken)
    {
        var ticketAgent = new TicketAgent
        {
            Id = request.Id,
            TicketAgentCode = request.TicketAgentCode,
            TicketAgentName = request.TicketAgentName,
            UpdatedDate = DateTime.Now
        };

        await _ticketAgentRepository.UpdateAsync(ticketAgent);
    }
}














































