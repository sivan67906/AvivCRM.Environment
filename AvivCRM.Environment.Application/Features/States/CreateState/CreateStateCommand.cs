using MediatR;

namespace AvivCRM.Environment.Application.Features.States.CreateState;

public class CreateStateCommand : IRequest
{
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid CountryId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}













