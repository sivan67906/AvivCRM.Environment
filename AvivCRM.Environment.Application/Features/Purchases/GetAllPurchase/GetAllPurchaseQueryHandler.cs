using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Purchases.GetAllPurchase;
public class GetAllPurchaseQueryHandler : IRequestHandler<GetAllPurchaseQuery, IEnumerable<PurchaseDTO>>
{
    private readonly IGenericRepository<Purchase> _purchaseRepository;
    public GetAllPurchaseQueryHandler(IGenericRepository<Purchase> purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    public async Task<IEnumerable<PurchaseDTO>> Handle(GetAllPurchaseQuery request, CancellationToken cancellationToken)
    {
        var clients = await _purchaseRepository.GetAllAsync();

        var clientlist = clients.Select(x => new PurchaseDTO
        {
            Id = x.Id,
            PurchaseOrderPrefix = x.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = x.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = x.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = x.PurchaseOrderNumberExample,
            BillOrderPrefix = x.BillOrderPrefix,
            BillOrderNumberSeperater = x.BillOrderNumberSeperater,

            BillOrderNumberDigits = x.BillOrderNumberDigits,
            BillOrderNumberExample = x.BillOrderNumberExample,

            VendorCreditPrefix = x.VendorCreditPrefix,
            VendorCreditNumberSeperater = x.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = x.VendorCreditNumberDigits,
            VendorCreditNumberExample = x.VendorCreditNumberExample,
        }).ToList();

        return clientlist;
    }
}
