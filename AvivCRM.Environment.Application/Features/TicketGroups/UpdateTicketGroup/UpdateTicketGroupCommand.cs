using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketGroups.UpdateTicketGroup;

public class UpdateTicketGroupCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketGroupCode { get; set; }
    public string? TicketGroupName { get; set; }
}








































