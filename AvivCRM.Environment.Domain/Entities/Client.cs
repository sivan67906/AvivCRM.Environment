using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace AvivCRM.Environment.Domain.Entities
{
    public sealed class Client
    {
        public Guid Id { get; set; }
        public string? ClientCode { get; set; }
        public string? ClientName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }
        

        [ForeignKey(nameof(CompanyId))]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }

        [ForeignKey(nameof(AddressId))]
        public Guid AddressId { get; set; }
        public Address? Address { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Guid CountryId { get; set; }
        public Country? Country { get; set; }

        [ForeignKey(nameof(StateId))]
        public Guid StateId { get; set; }
        public State? State { get; set; }

        [ForeignKey(nameof(CityId))]
        public Guid CityId { get; set; }
        public City? City { get; set; }

    }
}
