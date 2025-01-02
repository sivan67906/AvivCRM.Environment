using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketGroups.CreateTicketGroup;

public class CreateTicketGroupCommand : IRequest
{
    public string? TicketGroupCode { get; set; }
    public string? TicketGroupName { get; set; }
}








































