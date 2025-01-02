using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.GetAllRecruitCustomQuestionSettings;

internal class GetAllRecruitCustomQuestionSettingsQueryHandler : IRequestHandler<GetAllRecruitCustomQuestionSettingsQuery, IEnumerable<RecruitCustomQuestionSettingDTO>>
{
    private readonly IGenericRepository<RecruitCustomQuestionSetting> _recruitCustomQuestionSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruitCustomQuestionSettingsQueryHandler(
        IGenericRepository<RecruitCustomQuestionSetting> recruitCustomQuestionSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruitCustomQuestionSettingRepository = recruitCustomQuestionSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruitCustomQuestionSettingDTO>> Handle(GetAllRecruitCustomQuestionSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruitCustomQuestionSettings = await _recruitCustomQuestionSettingRepository.GetAllAsync();
        var projectReminderPersons = await _projectReminderPersonRepository.GetAllAsync();
        var projectReminderPersonsList = projectReminderPersons.Select(x => new ProjectReminderPersonDTO
        {
            Id = x.Id,
            Name = x.Name,
        }).ToList();

        var recruitCustomQuestionSettingList = recruitCustomQuestionSettings.Select(x => new RecruitCustomQuestionSettingDTO
        {
            Id = x.Id,
            CQQuestion = x.CQQuestion,
            CustomQuestionTypeId = x.CustomQuestionTypeId,
            CustomQuestionTypeName = x.CustomQuestionType.CQTypeName,
            CustomQuestionCategoryId = x.CustomQuestionCategoryId,
            CustomQuestionCategoryName = x.CustomQuestionCategory.CQCategoryName,
            CQStatusId = x.CQStatusId,
            CQIsRequiredId = x.CQIsRequiredId
        }).ToList();

        return recruitCustomQuestionSettingList;
    }
}
























