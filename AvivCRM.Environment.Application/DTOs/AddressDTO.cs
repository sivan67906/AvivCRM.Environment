namespace AvivCRM.Environment.Application.DTOs;

public class AddressDTO
{
    public Guid Id { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? ZipCode { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
    public Guid CityId { get; set; }
    public string? CityName { get; set; }
    public bool IsPrimary { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; }
}
