using MediatR;

namespace AvivCRM.Environment.Application.Features.Languages.CreateLanguage;

public class CreateLanguageCommand : IRequest
{
    public string? LanguageCode { get; set; }
    public string? LanguageName { get; set; }
}




























