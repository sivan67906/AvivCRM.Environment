using MediatR;

namespace AvivCRM.Environment.Application.Features.Payments.CreatePayment;
public class CreatePaymentCommand : IRequest<Guid>
{
    public string? Method { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; } = true;
}
