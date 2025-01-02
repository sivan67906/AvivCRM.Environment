using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.GetTicketReplyTemplateById;

internal class GetTicketReplyTemplateByIdQueryHandler : IRequestHandler<GetTicketReplyTemplateByIdQuery, TicketReplyTemplateDTO>
{
    private readonly IGenericRepository<TicketReplyTemplate> _ticketReplyTemplateRepository;

    public GetTicketReplyTemplateByIdQueryHandler(
        IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository) =>
        _ticketReplyTemplateRepository = ticketReplyTemplateRepository;

    public async Task<TicketReplyTemplateDTO> Handle(GetTicketReplyTemplateByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplate = await _ticketReplyTemplateRepository.GetByIdAsync(request.Id);
        if (ticketReplyTemplate == null) return null;
        return new TicketReplyTemplateDTO
        {
            Id = ticketReplyTemplate.Id,
            TicketReplyTemplateCode = ticketReplyTemplate.TicketReplyTemplateCode,
            TicketReplyTemplateName = ticketReplyTemplate.TicketReplyTemplateName
        };
    }
}








































