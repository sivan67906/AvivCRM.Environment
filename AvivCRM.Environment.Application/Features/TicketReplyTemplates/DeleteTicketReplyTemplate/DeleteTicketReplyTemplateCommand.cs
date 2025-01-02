using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.DeleteTicketReplyTemplate
{
    public class DeleteTicketReplyTemplateCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































