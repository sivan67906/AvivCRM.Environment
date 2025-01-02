using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.DeleteRecruitFooterSetting;

internal class DeleteRecruitFooterSettingCommandHandler : IRequestHandler<DeleteRecruitFooterSettingCommand>
{
    private readonly IGenericRepository<RecruitFooterSetting> _recruitFooterSettingRepository;

    public DeleteRecruitFooterSettingCommandHandler(
        IGenericRepository<RecruitFooterSetting> recruitFooterSettingRepository) =>
        _recruitFooterSettingRepository = recruitFooterSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitFooterSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitFooterSettingRepository.DeleteAsync(request.Id);
    }
}
























