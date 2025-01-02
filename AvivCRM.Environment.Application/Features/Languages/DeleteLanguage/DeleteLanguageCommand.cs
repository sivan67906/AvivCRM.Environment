using MediatR;

namespace AvivCRM.Environment.Application.Features.Languages.DeleteLanguage
{
    public class DeleteLanguageCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




























