using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.UpdateJobApplicationPosition;

public class UpdateJobApplicationPositionCommand : IRequest
{
    public Guid Id { get; set; }
    public string? JAPositionCode { get; set; }
    public string? JAPositionName { get; set; }
}
























