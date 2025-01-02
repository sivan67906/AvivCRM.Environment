using MediatR;

namespace AvivCRM.Environment.Application.Features.Purchases.UpdatePurchase;
public class UpdatePurchaseCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? PurchaseOrderPrefix { get; set; }
    public string? PurchaseOrderNumberSeperater { get; set; }
    public string? PurchaseOrderNumberDigits { get; set; }
    public string? PurchaseOrderNumberExample { get; set; }
    public string? BillOrderPrefix { get; set; }
    public string? BillOrderNumberSeperater { get; set; }
    public string? BillOrderNumberDigits { get; set; }
    public string? BillOrderNumberExample { get; set; }
    public string? VendorCreditPrefix { get; set; }
    public string? VendorCreditNumberSeperater { get; set; }
    public string? VendorCreditNumberDigits { get; set; }
    public string? VendorCreditNumberExample { get; set; }
}
