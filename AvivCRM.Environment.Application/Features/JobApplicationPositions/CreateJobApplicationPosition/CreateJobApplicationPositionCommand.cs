using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.CreateJobApplicationPosition;

public class CreateJobApplicationPositionCommand : IRequest
{
    public string? JAPositionCode { get; set; }
    public string? JAPositionName { get; set; }
}
























