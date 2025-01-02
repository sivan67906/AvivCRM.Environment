using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketTypes.DeleteTicketType
{
    public class DeleteTicketTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































