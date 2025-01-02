using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Payments.GetPaymentById;
public class GetPaymentByIdQuery : IRequest<PaymentDTO>
{
    public Guid Id { get; set; }
}
