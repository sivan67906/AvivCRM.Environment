using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Purchases.CreatePurchase;
public class CreatePurchaseCommandHandler : IRequestHandler<CreatePurchaseCommand, Guid>
{
    private readonly IGenericRepository<Purchase> _purchaseRepository;
    public CreatePurchaseCommandHandler(IGenericRepository<Purchase> purchaseRepository)
    {
        _purchaseRepository = purchaseRepository;
    }

    public async Task<Guid> Handle(CreatePurchaseCommand request, CancellationToken cancellationToken)
    {
        var client = new Purchase
        {
            PurchaseOrderPrefix = request.PurchaseOrderPrefix,
            PurchaseOrderNumberSeperater = request.PurchaseOrderNumberSeperater,
            PurchaseOrderNumberDigits = request.PurchaseOrderNumberDigits,
            PurchaseOrderNumberExample = request.PurchaseOrderNumberExample,
            BillOrderPrefix = request.BillOrderPrefix,
            BillOrderNumberSeperater = request.BillOrderNumberSeperater,

            BillOrderNumberDigits = request.BillOrderNumberDigits,
            BillOrderNumberExample = request.BillOrderNumberExample,

            VendorCreditPrefix = request.VendorCreditPrefix,
            VendorCreditNumberSeperater = request.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = request.VendorCreditNumberDigits,
            VendorCreditNumberExample = request.VendorCreditNumberExample,
        };
        await _purchaseRepository.CreateAsync(client);
        return client.Id;
    }
}
