using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.CreateTicketReplyTemplate;

internal class CreateTicketReplyTemplateCommandHandler(
    IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository) : IRequestHandler<CreateTicketReplyTemplateCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketReplyTemplateCommand request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplate = new TicketReplyTemplate
        {
            TicketReplyTemplateCode = request.TicketReplyTemplateCode,
            TicketReplyTemplateName = request.TicketReplyTemplateName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketReplyTemplateRepository.CreateAsync(ticketReplyTemplate);
    }
}








































