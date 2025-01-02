using MediatR;

namespace AvivCRM.Environment.Application.Features.Countries.UpdateCountry;

public class UpdateCountryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public required string Name { get; set; }
    public DateTime UpdatedDate { get; set; }
}













