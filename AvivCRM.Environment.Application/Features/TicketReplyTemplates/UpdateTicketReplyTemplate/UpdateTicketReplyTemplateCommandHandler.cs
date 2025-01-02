using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.UpdateTicketReplyTemplate;

internal class UpdateTicketReplyTemplateCommandHandler : IRequestHandler<UpdateTicketReplyTemplateCommand>
{
    private readonly IGenericRepository<TicketReplyTemplate> _ticketReplyTemplateRepository;

    public UpdateTicketReplyTemplateCommandHandler(
        IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository) =>
        _ticketReplyTemplateRepository = ticketReplyTemplateRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketReplyTemplateCommand request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplate = new TicketReplyTemplate
        {
            Id = request.Id,
            TicketReplyTemplateCode = request.TicketReplyTemplateCode,
            TicketReplyTemplateName = request.TicketReplyTemplateName,
            UpdatedDate = DateTime.Now
        };

        await _ticketReplyTemplateRepository.UpdateAsync(ticketReplyTemplate);
    }
}








































