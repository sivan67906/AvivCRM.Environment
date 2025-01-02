//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.GetCustomQuestionCategoryById
{
    public class GetCustomQuestionCategoryByIdQuery : IRequest<CustomQuestionCategoryDTO>
    {
        public Guid Id { get; set; }
    }
}
























