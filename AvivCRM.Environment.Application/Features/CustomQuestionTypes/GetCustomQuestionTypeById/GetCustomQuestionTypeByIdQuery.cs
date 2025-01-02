//using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.GetCustomQuestionTypeById
{
    public class GetCustomQuestionTypeByIdQuery : IRequest<CustomQuestionTypeDTO>
    {
        public Guid Id { get; set; }
    }
}
























