using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitGeneralSettings.DeleteRecruitGeneralSetting;

internal class DeleteRecruitGeneralSettingCommandHandler : IRequestHandler<DeleteRecruitGeneralSettingCommand>
{
    private readonly IGenericRepository<RecruitGeneralSetting> _recruitGeneralSettingRepository;

    public DeleteRecruitGeneralSettingCommandHandler(
        IGenericRepository<RecruitGeneralSetting> recruitGeneralSettingRepository) =>
        _recruitGeneralSettingRepository = recruitGeneralSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitGeneralSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitGeneralSettingRepository.DeleteAsync(request.Id);
    }
}
























