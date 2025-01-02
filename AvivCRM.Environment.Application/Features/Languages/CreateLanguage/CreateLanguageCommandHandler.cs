using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Languages.CreateLanguage;

internal class CreateLanguageCommandHandler(
    IGenericRepository<Language> languageRepository) : IRequestHandler<CreateLanguageCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
    {
        var language = new Language
        {
            LanguageCode = request.LanguageCode,
            LanguageName = request.LanguageName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await languageRepository.CreateAsync(language);
    }
}




























