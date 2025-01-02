using MediatR;

namespace AvivCRM.Environment.Application.Features.Clients.CreateClient;
public class CreateClientCommand : IRequest<Guid>
{

    public string? ClientCode { get; set; }
    public string? ClientName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Guid CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public Guid AddressId { get; set; }
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public Guid CountryId { get; set; }
    public Guid StateId { get; set; }
    public Guid CityId { get; set; }
    public string? Description { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public string StateName { get; set; } = string.Empty;
    public string CityName { get; set; } = string.Empty;
}
