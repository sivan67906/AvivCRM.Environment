using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitNotificationSettings.DeleteRecruitNotificationSetting;

internal class DeleteRecruitNotificationSettingCommandHandler : IRequestHandler<DeleteRecruitNotificationSettingCommand>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;

    public DeleteRecruitNotificationSettingCommandHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository) =>
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitNotificationSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitNotificationSettingRepository.DeleteAsync(request.Id);
    }
}
























