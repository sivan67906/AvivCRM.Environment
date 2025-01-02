using MediatR;

namespace AvivCRM.Environment.Application.Features.Languages.UpdateLanguage;

public class UpdateLanguageCommand : IRequest
{
    public Guid Id { get; set; }
    public string? LanguageCode { get; set; }
    public string? LanguageName { get; set; }
}




























