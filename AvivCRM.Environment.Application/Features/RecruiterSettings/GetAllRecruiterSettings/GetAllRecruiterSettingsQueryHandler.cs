using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.GetAllRecruiterSettings;

internal class GetAllRecruiterSettingsQueryHandler : IRequestHandler<GetAllRecruiterSettingsQuery, IEnumerable<RecruiterSettingDTO>>
{
    private readonly IGenericRepository<RecruiterSetting> _recruiterSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruiterSettingsQueryHandler(
        IGenericRepository<RecruiterSetting> recruiterSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruiterSettingRepository = recruiterSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruiterSettingDTO>> Handle(GetAllRecruiterSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruiterSettings = await _recruiterSettingRepository.GetAllAsync();

        var recruiterSettingList = recruiterSettings.Select(x => new RecruiterSettingDTO
        {
            Id = x.Id,
            RecruiterName = x.RecruiterName,
            RecruiterStatusId = x.RecruiterStatusId,
        }).ToList();

        return recruiterSettingList;
    }
}
























