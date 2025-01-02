//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TicketGroups.GetTicketGroupById
{
    public class GetTicketGroupByIdQuery : IRequest<TicketGroupDTO>
    {
        public Guid Id { get; set; }
    }
}








































