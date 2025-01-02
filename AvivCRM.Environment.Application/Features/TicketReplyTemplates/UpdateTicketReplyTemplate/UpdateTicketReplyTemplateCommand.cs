using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.UpdateTicketReplyTemplate;

public class UpdateTicketReplyTemplateCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketReplyTemplateCode { get; set; }
    public string? TicketReplyTemplateName { get; set; }
}








































