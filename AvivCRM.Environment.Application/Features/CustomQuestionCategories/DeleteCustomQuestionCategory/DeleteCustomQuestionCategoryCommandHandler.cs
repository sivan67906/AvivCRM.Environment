using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.DeleteCustomQuestionCategory;

internal class DeleteCustomQuestionCategoryCommandHandler : IRequestHandler<DeleteCustomQuestionCategoryCommand>
{
    private readonly IGenericRepository<CustomQuestionCategory> _customQuestionCategoryRepository;

    public DeleteCustomQuestionCategoryCommandHandler(
        IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository) =>
        _customQuestionCategoryRepository = customQuestionCategoryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCustomQuestionCategoryCommand request, CancellationToken cancellationToken)
    {
        await _customQuestionCategoryRepository.DeleteAsync(request.Id);
    }
}
























