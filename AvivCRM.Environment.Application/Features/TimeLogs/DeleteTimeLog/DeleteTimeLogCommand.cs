using MediatR;

namespace AvivCRM.Environment.Application.Features.TimeLogs.DeleteTimeLog
{
    public class DeleteTimeLogCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




























