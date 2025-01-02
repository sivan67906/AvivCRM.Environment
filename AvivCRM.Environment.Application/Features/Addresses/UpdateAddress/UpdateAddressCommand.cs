using MediatR;

namespace AvivCRM.Environment.Application.Features.Addresses.UpdateAddress;

public class UpdateAddressCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public Guid CityId { get; set; }
    public bool IsPrimary { get; set; }
    public DateTime UpdatedDate { get; set; }
}













