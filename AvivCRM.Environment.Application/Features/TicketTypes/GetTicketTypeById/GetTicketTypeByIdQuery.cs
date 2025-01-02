//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TicketTypes.GetTicketTypeById
{
    public class GetTicketTypeByIdQuery : IRequest<TicketTypeDTO>
    {
        public Guid Id { get; set; }
    }
}








































