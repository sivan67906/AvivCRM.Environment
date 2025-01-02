using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.UpdatePurchaseOrder;
public class UpdatePurchaseOrderCommandHandler : IRequestHandler<UpdatePurchaseOrderCommand, Guid>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseOrderRepository;
    public UpdatePurchaseOrderCommandHandler(IGenericRepository<PurchaseOrder> purchaseOrderRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<Guid> Handle(UpdatePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        var purchaseOrder = new PurchaseOrder
        {
            Id = request.Id,
            PurchaseOrderPrefix = request.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = request.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = request.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = request.PurchaseOrderNumberExample,
        };
        await _purchaseOrderRepository.UpdateAsync(purchaseOrder);
        return request.Id;
    }
}
