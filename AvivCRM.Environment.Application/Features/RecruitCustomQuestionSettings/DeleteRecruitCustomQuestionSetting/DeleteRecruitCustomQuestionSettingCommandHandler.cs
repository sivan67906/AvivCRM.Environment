using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.DeleteRecruitCustomQuestionSetting;

internal class DeleteRecruitCustomQuestionSettingCommandHandler : IRequestHandler<DeleteRecruitCustomQuestionSettingCommand>
{
    private readonly IGenericRepository<RecruitCustomQuestionSetting> _recruitCustomQuestionSettingRepository;

    public DeleteRecruitCustomQuestionSettingCommandHandler(
        IGenericRepository<RecruitCustomQuestionSetting> recruitCustomQuestionSettingRepository) =>
        _recruitCustomQuestionSettingRepository = recruitCustomQuestionSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruitCustomQuestionSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruitCustomQuestionSettingRepository.DeleteAsync(request.Id);
    }
}
























