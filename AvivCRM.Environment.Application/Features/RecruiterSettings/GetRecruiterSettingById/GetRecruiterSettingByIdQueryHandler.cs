using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.GetRecruiterSettingById;

internal class GetRecruiterSettingByIdQueryHandler : IRequestHandler<GetRecruiterSettingByIdQuery, RecruiterSettingDTO>
{
    private readonly IGenericRepository<RecruiterSetting> _recruiterSettingRepository;

    public GetRecruiterSettingByIdQueryHandler(
        IGenericRepository<RecruiterSetting> recruiterSettingRepository) =>
        _recruiterSettingRepository = recruiterSettingRepository;

    public async Task<RecruiterSettingDTO> Handle(GetRecruiterSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruiterSetting = await _recruiterSettingRepository.GetByIdAsync(request.Id);
        if (recruiterSetting == null) return null;
        return new RecruiterSettingDTO
        {
            Id = recruiterSetting.Id,
            RecruiterName = recruiterSetting.RecruiterName,
            RecruiterStatusId = recruiterSetting.RecruiterStatusId
        };
    }
}
























