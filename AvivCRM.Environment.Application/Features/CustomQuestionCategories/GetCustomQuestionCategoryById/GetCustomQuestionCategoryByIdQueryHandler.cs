using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionCategories.GetCustomQuestionCategoryById;

internal class GetCustomQuestionCategoryByIdQueryHandler : IRequestHandler<GetCustomQuestionCategoryByIdQuery, CustomQuestionCategoryDTO>
{
    private readonly IGenericRepository<CustomQuestionCategory> _customQuestionCategoryRepository;

    public GetCustomQuestionCategoryByIdQueryHandler(
        IGenericRepository<CustomQuestionCategory> customQuestionCategoryRepository) =>
        _customQuestionCategoryRepository = customQuestionCategoryRepository;

    public async Task<CustomQuestionCategoryDTO> Handle(GetCustomQuestionCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var customQuestionCategory = await _customQuestionCategoryRepository.GetByIdAsync(request.Id);
        if (customQuestionCategory == null) return null;
        return new CustomQuestionCategoryDTO
        {
            Id = customQuestionCategory.Id,
            CQCategoryCode = customQuestionCategory.CQCategoryCode,
            CQCategoryName = customQuestionCategory.CQCategoryName
        };
    }
}
























