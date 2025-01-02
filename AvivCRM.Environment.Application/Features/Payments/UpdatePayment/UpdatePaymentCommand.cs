using MediatR;

namespace AvivCRM.Environment.Application.Features.Payments.UpdatePayment;
public class UpdatePaymentCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? Method { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; } = true;
}
