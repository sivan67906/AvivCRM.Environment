namespace AvivCRM.Environment.Domain.Entities;
public class BillOrder
{
    public Guid Id { get; set; }
    public string? BillOrderPrefix { get; set; }
    public string? BillOrderNumberSeperater { get; set; }
    public string? BillOrderNumberDigits { get; set; }
    public string? BillOrderNumberExample { get; set; }
}
