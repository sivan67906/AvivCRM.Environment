using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.UpdateBusinessLocation;

public class UpdateBusinessLocationCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? TaxName { get; set; }
    public string? TaxNumber { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public Guid CountryId { get; set; }
    public Guid StateId { get; set; }
    public Guid CityId { get; set; }
    public string? CountryName { get; set; }
    public string? StateName { get; set; }
    public string? CityName { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; }
}

