using MediatR;

namespace AvivCRM.Environment.Application.Features.Cities.CreateCity;

public class CreateCityCommand : IRequest
{
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid StateId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}

















