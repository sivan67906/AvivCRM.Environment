using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.DeletePurchaseOrder;
public class DeletePurchaseOrderCommandHandler : IRequestHandler<DeletePurchaseOrderCommand>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseOrderRepository;
    public DeletePurchaseOrderCommandHandler(IGenericRepository<PurchaseOrder> purchaseOrderRepository)
    {
        _purchaseOrderRepository = purchaseOrderRepository;
    }

    public async System.Threading.Tasks.Task Handle(DeletePurchaseOrderCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _purchaseOrderRepository.DeleteAsync(request.Id);
    }
}
