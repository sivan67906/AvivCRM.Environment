using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketReplyTemplates.DeleteTicketReplyTemplate;

internal class DeleteTicketReplyTemplateCommandHandler : IRequestHandler<DeleteTicketReplyTemplateCommand>
{
    private readonly IGenericRepository<TicketReplyTemplate> _timeLogRepository;

    public DeleteTicketReplyTemplateCommandHandler(
        IGenericRepository<TicketReplyTemplate> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTicketReplyTemplateCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































