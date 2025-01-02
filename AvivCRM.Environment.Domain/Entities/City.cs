using System.ComponentModel.DataAnnotations.Schema;

namespace AvivCRM.Environment.Domain.Entities;

public class City
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;

    [ForeignKey(nameof(StateId))]
    public Guid StateId { get; set; }
    public State State { get; set; } = null!;
}

