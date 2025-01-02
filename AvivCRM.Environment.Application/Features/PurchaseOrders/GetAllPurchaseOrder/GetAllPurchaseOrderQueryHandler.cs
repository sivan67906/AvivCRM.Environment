using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.GetAllPurchaseOrder;
public class GetAllPurchaseOrderQueryHandler : IRequestHandler<GetAllPurchaseOrderQuery, IEnumerable<PurchaseOrderDTO>>
{
    private readonly IGenericRepository<PurchaseOrder> _purchaseorderrepo;
    public GetAllPurchaseOrderQueryHandler(IGenericRepository<PurchaseOrder> purchaseorderrepo)
    {
        _purchaseorderrepo = purchaseorderrepo;
    }

    public async Task<IEnumerable<PurchaseOrderDTO>> Handle(GetAllPurchaseOrderQuery request, CancellationToken cancellationToken)
    {
        var purchaseOrders = await _purchaseorderrepo.GetAllAsync();

        var purchaselist = purchaseOrders.Select(x => new PurchaseOrderDTO
        {
            Id = x.Id,
            PurchaseOrderPrefix = x.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = x.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = x.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = x.PurchaseOrderNumberExample,
        }).ToList();

        return purchaselist;
    }
}
