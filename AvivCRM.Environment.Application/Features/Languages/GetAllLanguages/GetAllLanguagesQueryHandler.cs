using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Languages.GetAllLanguages;

internal class GetAllLanguagesQueryHandler : IRequestHandler<GetAllLanguagesQuery, IEnumerable<LanguageDTO>>
{
    private readonly IGenericRepository<Language> _languageRepository;

    public GetAllLanguagesQueryHandler(
        IGenericRepository<Language> languageRepository)
    {
        _languageRepository = languageRepository;
    }

    public async Task<IEnumerable<LanguageDTO>> Handle(GetAllLanguagesQuery request, CancellationToken cancellationToken)
    {
        var languages = await _languageRepository.GetAllAsync();
        var languageList = languages.Select(x => new LanguageDTO
        {
            Id = x.Id,
            LanguageCode = x.LanguageCode,
            LanguageName = x.LanguageName
        }).ToList();

        return languageList;
    }
}




























