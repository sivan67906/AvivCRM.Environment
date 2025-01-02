using MediatR;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.CreatePurchaseOrder;
public class CreatePurchaseOrderCommand : IRequest<Guid>
{

    public string? PurchaseOrderPrefix { get; set; }
    public string? PurchaseOrderNumberSeperater { get; set; }
    public string? PurchaseOrderNumberDigits { get; set; }
    public string? PurchaseOrderNumberExample { get; set; }
}
