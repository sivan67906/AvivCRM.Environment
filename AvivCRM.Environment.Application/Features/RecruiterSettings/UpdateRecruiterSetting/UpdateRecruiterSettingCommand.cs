using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.UpdateRecruiterSetting;

public class UpdateRecruiterSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? RecruiterName { get; set; }
    public int RecruiterStatusId { get; set; }
}
























