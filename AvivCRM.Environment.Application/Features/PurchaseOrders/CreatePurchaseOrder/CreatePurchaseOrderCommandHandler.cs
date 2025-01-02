using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.CreatePurchaseOrder;
public class CreatePurchaseOrderCommandHandler : IRequestHandler<CreatePurchaseOrderCommand, Guid>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseOrderRepository;
    public CreatePurchaseOrderCommandHandler(IGenericRepository<PurchaseOrder> purchaseOrderRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
    }

    public async Task<Guid> Handle(CreatePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        var client = new PurchaseOrder
        {
            PurchaseOrderPrefix = request.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = request.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = request.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = request.PurchaseOrderNumberExample,
        };
        await _purchaseOrderRepository.CreateAsync(client);
        return client.Id;
    }
}
