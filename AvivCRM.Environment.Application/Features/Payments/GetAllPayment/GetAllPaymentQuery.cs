using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Payments.GetAllPayment;
public class GetAllPaymentQuery : IRequest<IEnumerable<PaymentDTO>>
{
}
