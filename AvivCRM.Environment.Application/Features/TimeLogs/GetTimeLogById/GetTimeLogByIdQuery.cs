//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TimeLogs.GetTimeLogById
{
    public class GetTimeLogByIdQuery : IRequest<TimeLogDTO>
    {
        public Guid Id { get; set; }
    }
}




























