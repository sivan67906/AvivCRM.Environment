using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.CreateCustomQuestionCategory;

internal class CreateCustomQuestionCategoryCommandHandler(
    IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository) : IRequestHandler<CreateCustomQuestionCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCustomQuestionCategoryCommand request, CancellationToken cancellationToken)
    {
        var customQuestionCategory = new CustomQuestionCategory
        {
            CQCategoryCode = request.CQCategoryCode,
            CQCategoryName = request.CQCategoryName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await customQuestionCategoryRepository.CreateAsync(customQuestionCategory);
    }
}
























