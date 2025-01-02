//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TicketAgents.GetTicketAgentById
{
    public class GetTicketAgentByIdQuery : IRequest<TicketAgentDTO>
    {
        public Guid Id { get; set; }
    }
}














































