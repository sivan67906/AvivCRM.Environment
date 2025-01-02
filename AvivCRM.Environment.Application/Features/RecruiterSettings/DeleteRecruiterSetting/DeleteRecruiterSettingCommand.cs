using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.DeleteRecruiterSetting
{
    public class DeleteRecruiterSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























