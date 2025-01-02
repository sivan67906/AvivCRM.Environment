using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.CreateRecruiterSetting;

internal class CreateRecruiterSettingCommandHandler(
    IGenericRepository<RecruiterSetting> recruiterSettingRepository) : IRequestHandler<CreateRecruiterSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruiterSettingCommand request, CancellationToken cancellationToken)
    {
        var recruiterSetting = new RecruiterSetting
        {
            RecruiterName = request.RecruiterName,
            RecruiterStatusId = request.RecruiterStatusId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruiterSettingRepository.CreateAsync(recruiterSetting);
    }
}
























