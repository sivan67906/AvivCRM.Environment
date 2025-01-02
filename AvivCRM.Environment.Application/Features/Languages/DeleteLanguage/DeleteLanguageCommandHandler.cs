using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Languages.DeleteLanguage;

internal class DeleteLanguageCommandHandler : IRequestHandler<DeleteLanguageCommand>
{
    private readonly IGenericRepository<Language> _timeLogRepository;

    public DeleteLanguageCommandHandler(
        IGenericRepository<Language> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteLanguageCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}




























