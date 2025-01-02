using MediatR;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.DeletePurchaseOrder;
public class DeletePurchaseOrderCommand : IRequest
{
    public Guid Id { get; set; }
}
