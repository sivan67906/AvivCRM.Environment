using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.UpdateRecruitFooterSetting;

internal class UpdateRecruitFooterSettingCommandHandler : IRequestHandler<UpdateRecruitFooterSettingCommand>
{
    private readonly IGenericRepository<RecruitFooterSetting> _recruitFooterSettingRepository;

    public UpdateRecruitFooterSettingCommandHandler(
        IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository) =>
        _recruitFooterSettingRepository = recruitFooterSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRecruitFooterSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitFooterSetting = new RecruitFooterSetting
        {
            Id = request.Id,
            FooterTitle = request.FooterTitle,
            FooterSlug = request.FooterSlug,
            FooterStatusId = request.FooterStatusId,
            FooterDescription = request.FooterDescription,
            UpdatedDate = DateTime.Now
        };

        await _recruitFooterSettingRepository.UpdateAsync(recruitFooterSetting);
    }
}
























