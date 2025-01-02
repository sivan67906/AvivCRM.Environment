using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketAgents.DeleteTicketAgent;

internal class DeleteTicketAgentCommandHandler : IRequestHandler<DeleteTicketAgentCommand>
{
    private readonly IGenericRepository<TicketAgent> _ticketAgentRepository;

    public DeleteTicketAgentCommandHandler(
        IGenericRepository<TicketAgent> ticketAgentRepository) =>
        _ticketAgentRepository = ticketAgentRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketAgentCommand request, CancellationToken cancellationToken)
    {
        await _ticketAgentRepository.DeleteAsync(request.Id);
    }
}














































