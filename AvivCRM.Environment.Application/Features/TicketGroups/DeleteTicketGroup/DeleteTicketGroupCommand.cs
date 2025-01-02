using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketGroups.DeleteTicketGroup
{
    public class DeleteTicketGroupCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































