using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.CreateRecruitFooterSetting;

internal class CreateRecruitFooterSettingCommandHandler(
    IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository) : IRequestHandler<CreateRecruitFooterSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitFooterSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitFooterSetting = new RecruitFooterSetting
        {
            FooterTitle = request.FooterTitle,
            FooterSlug = request.FooterSlug,
            FooterStatusId = request.FooterStatusId,
            FooterDescription = request.FooterDescription,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitFooterSettingRepository.CreateAsync(recruitFooterSetting);
    }
}
























