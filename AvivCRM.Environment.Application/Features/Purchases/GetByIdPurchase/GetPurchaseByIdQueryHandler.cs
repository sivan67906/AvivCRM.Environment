using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Purchases.GetByIdPurchase;
public class GetPurchaseByIdQueryHandler : IRequestHandler<GetPurchaseByIdQuery, PurchaseDTO>
{
    private readonly IGenericRepository<Purchase> _purchaseRepository;
    public GetPurchaseByIdQueryHandler(IGenericRepository<Purchase> purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    public async Task<PurchaseDTO> Handle(GetPurchaseByIdQuery request, CancellationToken cancellationToken)
    {
        var purchase = await _purchaseRepository.GetByIdAsync(request.Id);
        if (purchase == null) return null;
        return new PurchaseDTO
        {
            Id = purchase.Id,
            PurchaseOrderPrefix = purchase.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = purchase.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = purchase.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = purchase.PurchaseOrderNumberExample,
            BillOrderPrefix = purchase.BillOrderPrefix,
            BillOrderNumberSeperater = purchase.BillOrderNumberSeperater,

            BillOrderNumberDigits = purchase.BillOrderNumberDigits,
            BillOrderNumberExample = purchase.BillOrderNumberExample,

            VendorCreditPrefix = purchase.VendorCreditPrefix,
            VendorCreditNumberSeperater = purchase.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = purchase.VendorCreditNumberDigits,
            VendorCreditNumberExample = purchase.VendorCreditNumberExample,

        };
    }
}
