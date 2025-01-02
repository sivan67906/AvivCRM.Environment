namespace AvivCRM.Environment.Application.DTOs;

public class ProjectStatusDTO
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ColorCode { get; set; }
    public bool IsDefaultStatus { get; set; }
    public bool Status { get; set; }
}