namespace AvivCRM.Environment.Domain.Entities;
public class PurchaseOrder
{
    public Guid Id { get; set; }
    public string? PurchaseOrderPrefix { get; set; }
    public string? PurchaseOrderNumberSeperater { get; set; }
    public string? PurchaseOrderNumberDigits { get; set; }
    public string? PurchaseOrderNumberExample { get; set; }
}
