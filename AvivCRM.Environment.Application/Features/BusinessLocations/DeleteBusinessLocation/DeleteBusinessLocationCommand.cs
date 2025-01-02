using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.DeleteBusinessLocation
{
    public class DeleteBusinessLocationCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public Guid CountryId { get; set; }
        public Guid StateId { get; set; }
        public Guid CityId { get; set; }
        public string ZipCode { get; set; } = string.Empty;
        public string TaxName { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string Latitude { get; set; } = string.Empty;
        public string Longitude { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

