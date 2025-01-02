using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Categories.CreateCategory;

internal class CreateCategoryCommandHandler(
    IGenericRepository<Category> categoryRepository) : IRequestHandler<CreateCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = new Category
        {

        };

        await categoryRepository.CreateAsync(category);
    }
}









