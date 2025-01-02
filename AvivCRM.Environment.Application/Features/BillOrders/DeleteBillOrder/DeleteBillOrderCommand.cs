using MediatR;

namespace AvivCRM.Environment.Application.Features.BillOrders.DeleteBillOrder;
public class DeleteBillOrderCommand : IRequest
{
    public Guid Id { get; set; }
}
