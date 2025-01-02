//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.GetTicketReplyTemplateById
{
    public class GetTicketReplyTemplateByIdQuery : IRequest<TicketReplyTemplateDTO>
    {
        public Guid Id { get; set; }
    }
}








































