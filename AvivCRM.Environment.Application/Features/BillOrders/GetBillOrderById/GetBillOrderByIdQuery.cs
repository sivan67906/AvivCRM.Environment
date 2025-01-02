using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.BillOrders.GetBillOrderById;
public class GetBillOrderByIdQuery : IRequest<BillOrderDTO>
{
    public Guid Id { get; set; }
}
