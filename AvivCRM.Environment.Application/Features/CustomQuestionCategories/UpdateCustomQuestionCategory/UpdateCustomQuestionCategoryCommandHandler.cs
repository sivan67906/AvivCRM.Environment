using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.UpdateCustomQuestionCategory;

internal class UpdateCustomQuestionCategoryCommandHandler : IRequestHandler<UpdateCustomQuestionCategoryCommand>
{
    private readonly IGenericRepository<CustomQuestionCategory> _customQuestionCategoryRepository;

    public UpdateCustomQuestionCategoryCommandHandler(
        IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository) =>
        _customQuestionCategoryRepository = customQuestionCategoryRepository;

    public async System.Threading.Tasks.Task Handle(UpdateCustomQuestionCategoryCommand request, CancellationToken cancellationToken)
    {
        var customQuestionCategory = new CustomQuestionCategory
        {
            Id = request.Id,
            CQCategoryCode = request.CQCategoryCode,
            CQCategoryName = request.CQCategoryName,
            UpdatedDate = DateTime.Now
        };

        await _customQuestionCategoryRepository.UpdateAsync(customQuestionCategory);
    }
}
























