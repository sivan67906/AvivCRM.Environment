//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Languages.GetLanguageById
{
    public class GetLanguageByIdQuery : IRequest<LanguageDTO>
    {
        public Guid Id { get; set; }
    }
}




























