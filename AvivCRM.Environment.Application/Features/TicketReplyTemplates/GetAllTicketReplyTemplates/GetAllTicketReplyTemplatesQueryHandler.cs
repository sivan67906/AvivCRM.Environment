using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.GetAllTicketReplyTemplates;

internal class GetAllTicketReplyTemplatesQueryHandler : IRequestHandler<GetAllTicketReplyTemplatesQuery, IEnumerable<TicketReplyTemplateDTO>>
{
    private readonly IGenericRepository<TicketReplyTemplate> _ticketReplyTemplateRepository;

    public GetAllTicketReplyTemplatesQueryHandler(
        IGenericRepository<TicketReplyTemplate> ticketReplyTemplateRepository)
    {
        _ticketReplyTemplateRepository = ticketReplyTemplateRepository;
    }

    public async Task<IEnumerable<TicketReplyTemplateDTO>> Handle(GetAllTicketReplyTemplatesQuery request, CancellationToken cancellationToken)
    {
        var ticketReplyTemplates = await _ticketReplyTemplateRepository.GetAllAsync();
        var ticketReplyTemplateList = ticketReplyTemplates.Select(x => new TicketReplyTemplateDTO
        {
            Id = x.Id,
            TicketReplyTemplateCode = x.TicketReplyTemplateCode,
            TicketReplyTemplateName = x.TicketReplyTemplateName
        }).ToList();

        return ticketReplyTemplateList;
    }
}








































