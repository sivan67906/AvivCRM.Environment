using MediatR;

namespace AvivCRM.Environment.Application.Features.TicketTypes.CreateTicketType;

public class CreateTicketTypeCommand : IRequest
{
    public string? TicketTypeCode { get; set; }
    public string? TicketTypeName { get; set; }
}








































