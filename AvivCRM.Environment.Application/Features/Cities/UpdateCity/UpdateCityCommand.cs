using MediatR;

namespace AvivCRM.Environment.Application.Features.Cities.UpdateCity;

public class UpdateCityCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public Guid StateId { get; set; }
    public DateTime UpdatedDate { get; set; }
}

















