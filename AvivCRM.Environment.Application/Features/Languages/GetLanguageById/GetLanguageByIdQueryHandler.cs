using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Languages.GetLanguageById;

internal class GetLanguageByIdQueryHandler : IRequestHandler<GetLanguageByIdQuery, LanguageDTO>
{
    private readonly IGenericRepository<Language> _languageRepository;

    public GetLanguageByIdQueryHandler(
        IGenericRepository<Language> languageRepository) =>
        _languageRepository = languageRepository;

    public async Task<LanguageDTO> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
    {
        var language = await _languageRepository.GetByIdAsync(request.Id);
        if (language == null) return null;
        return new LanguageDTO
        {
            Id = language.Id,
            LanguageCode = language.LanguageCode,
            LanguageName = language.LanguageName
        };
    }
}




























