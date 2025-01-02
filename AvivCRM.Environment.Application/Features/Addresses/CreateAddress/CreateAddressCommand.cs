using MediatR;

namespace AvivCRM.Environment.Application.Features.Addresses.CreateAddress;

public class CreateAddressCommand : IRequest
{
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public Guid CityId { get; set; }
    public bool IsPrimary { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}













