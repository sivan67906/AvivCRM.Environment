using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketTypes.UpdateTicketType;

public class UpdateTicketTypeCommand : IRequest
{
    public Guid Id { get; set; }
    public string? TicketTypeCode { get; set; }
    public string? TicketTypeName { get; set; }
}








































