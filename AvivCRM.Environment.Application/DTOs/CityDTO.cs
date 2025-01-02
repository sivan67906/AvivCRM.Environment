namespace AvivCRM.Environment.Application.DTOs;

public class CityDTO
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid StateId { get; set; }
    public string? StateName { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; }
}

