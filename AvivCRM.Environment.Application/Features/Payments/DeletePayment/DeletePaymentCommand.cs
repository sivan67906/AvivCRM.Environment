using MediatR;

namespace AvivCRM.Environment.Application.Features.Payments.DeletePayment;
public class DeletePaymentCommand : IRequest
{
    public Guid Id { get; set; }
}
