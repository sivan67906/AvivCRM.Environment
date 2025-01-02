//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.GetJobApplicationPositionById
{
    public class GetJobApplicationPositionByIdQuery : IRequest<JobApplicationPositionDTO>
    {
        public Guid Id { get; set; }
    }
}
























