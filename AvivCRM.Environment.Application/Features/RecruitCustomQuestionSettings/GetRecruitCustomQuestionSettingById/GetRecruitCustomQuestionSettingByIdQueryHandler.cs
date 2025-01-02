using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.GetRecruitCustomQuestionSettingById;

internal class GetRecruitCustomQuestionSettingByIdQueryHandler : IRequestHandler<GetRecruitCustomQuestionSettingByIdQuery, RecruitCustomQuestionSettingDTO>
{
    private readonly IGenericRepository<RecruitCustomQuestionSetting> _recruitCustomQuestionSettingRepository;

    public GetRecruitCustomQuestionSettingByIdQueryHandler(
        IGenericRepository<RecruitCustomQuestionSetting> recruitCustomQuestionSettingRepository) =>
        _recruitCustomQuestionSettingRepository = recruitCustomQuestionSettingRepository;

    public async Task<RecruitCustomQuestionSettingDTO> Handle(GetRecruitCustomQuestionSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruitCustomQuestionSetting = await _recruitCustomQuestionSettingRepository.GetByIdAsync(request.Id);
        if (recruitCustomQuestionSetting == null) return null;
        return new RecruitCustomQuestionSettingDTO
        {
            Id = recruitCustomQuestionSetting.Id,
            CQQuestion = recruitCustomQuestionSetting.CQQuestion,
            CustomQuestionTypeId = recruitCustomQuestionSetting.CustomQuestionTypeId,
            CustomQuestionTypeName = recruitCustomQuestionSetting.CustomQuestionType.CQTypeName,
            CustomQuestionCategoryId = recruitCustomQuestionSetting.CustomQuestionCategoryId,
            CustomQuestionCategoryName = recruitCustomQuestionSetting.CustomQuestionCategory.CQCategoryName,
            CQStatusId = recruitCustomQuestionSetting.CQStatusId,
            CQIsRequiredId = recruitCustomQuestionSetting.CQIsRequiredId
        };
    }
}
























