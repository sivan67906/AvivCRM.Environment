namespace AvivCRM.Environment.Domain.Entities;

public class Country
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    // Navigation Property
    public ICollection<State> States { get; set; } = new List<State>();
}

