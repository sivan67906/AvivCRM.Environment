using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Categories.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<CategoryDTO>
    {
        public Guid Id { get; set; }
    }
}









