using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.CreateTicketReplyTemplate;

public class CreateTicketReplyTemplateCommand : IRequest
{
    public string? TicketReplyTemplateCode { get; set; }
    public string? TicketReplyTemplateName { get; set; }
}








































