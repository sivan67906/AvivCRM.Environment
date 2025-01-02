using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.DeleteJobApplicationPosition
{
    public class DeleteJobApplicationPositionCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























