using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.DeleteRecruiterSetting;

internal class DeleteRecruiterSettingCommandHandler : IRequestHandler<DeleteRecruiterSettingCommand>
{
    private readonly IGenericRepository<RecruiterSetting> _recruiterSettingRepository;

    public DeleteRecruiterSettingCommandHandler(
        IGenericRepository<RecruiterSetting> recruiterSettingRepository) =>
        _recruiterSettingRepository = recruiterSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRecruiterSettingCommand request, CancellationToken cancellationToken)
    {
        await _recruiterSettingRepository.DeleteAsync(request.Id);
    }
}
























