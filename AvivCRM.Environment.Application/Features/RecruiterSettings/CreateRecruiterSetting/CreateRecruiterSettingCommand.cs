using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.CreateRecruiterSetting;

public class CreateRecruiterSettingCommand : IRequest
{
    public string? RecruiterName { get; set; }
    public int RecruiterStatusId { get; set; }
}
























