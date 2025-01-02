using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.GetPurchaseOrderById;
public class GetPurchaseOrderByIdQueryHandler : IRequestHandler<GetPurchaseOrderByIdQuery, PurchaseOrderDTO>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseorderrepo;
    public GetPurchaseOrderByIdQueryHandler(IGenericRepository<PurchaseOrder> purchaseorderrepo)
    {
        _purchaseorderrepo = purchaseorderrepo;
    }

    public async Task<PurchaseOrderDTO> Handle(GetPurchaseOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var purchase = await _purchaseorderrepo.GetByIdAsync(request.Id);
        if (purchase == null) return null;
        return new PurchaseOrderDTO
        {
            Id = purchase.Id,
            PurchaseOrderPrefix = purchase.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = purchase.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = purchase.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = purchase.PurchaseOrderNumberExample,
        };
    }
}
