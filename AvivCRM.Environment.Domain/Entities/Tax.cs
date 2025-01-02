namespace AvivCRM.Environment.Domain.Entities;
public class Tax
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public float Rate {  get; set; }
}
