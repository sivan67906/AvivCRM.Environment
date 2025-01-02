using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Languages.UpdateLanguage;

internal class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommand>
{
    private readonly IGenericRepository<Language> _languageRepository;

    public UpdateLanguageCommandHandler(
        IGenericRepository<Language> languageRepository) =>
        _languageRepository = languageRepository;

    public async System.Threading.Tasks.Task Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
    {
        var language = new Language
        {
            Id = request.Id,
            LanguageCode = request.LanguageCode,
            LanguageName = request.LanguageName,
            UpdatedDate = DateTime.Now
        };

        await _languageRepository.UpdateAsync(language);
    }
}




























