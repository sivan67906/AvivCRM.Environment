using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.DeleteRecruitJobApplicationStatusSetting;

internal class DeleteRecruitJobApplicationStatusSettingCommandHandler : IRequestHandler<DeleteRecruitJobApplicationStatusSettingCommand>
{
    private readonly IGenericRepository<RecruitJobApplicationStatusSetting> _recruitJobApplicationStatusSettingRepository;

    public DeleteRecruitJobApplicationStatusSettingCommandHandler(
        IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository) =>
        _recruitJobApplicationStatusSettingRepository = recruitJobApplicationStatusSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitJobApplicationStatusSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitJobApplicationStatusSettingRepository.DeleteAsync(request.Id);
    }
}
























