namespace AvivCRM.Environment.Domain.Entities;
public class Payment
{
    public Guid Id { get; set; }
    public string? Method { get; set; }
    public string? Description { get; set; }
    public bool Status {  get; set; }=true;
}
