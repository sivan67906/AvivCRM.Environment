using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.GetCustomQuestionTypeById;

internal class GetCustomQuestionTypeByIdQueryHandler : IRequestHandler<GetCustomQuestionTypeByIdQuery, CustomQuestionTypeDTO>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;

    public GetCustomQuestionTypeByIdQueryHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository) =>
        _customQuestionTypeRepository = customQuestionTypeRepository;

    public async Task<CustomQuestionTypeDTO> Handle(GetCustomQuestionTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var customQuestionType = await _customQuestionTypeRepository.GetByIdAsync(request.Id);
        if (customQuestionType == null) return null;
        return new CustomQuestionTypeDTO
        {
            Id = customQuestionType.Id,
            CQTypeCode = customQuestionType.CQTypeCode,
            CQTypeName = customQuestionType.CQTypeName
        };
    }
}
























