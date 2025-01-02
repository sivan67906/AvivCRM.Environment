using AvivCRM.Environment.Domain.Entities.Common;

namespace AvivCRM.Environment.Domain.Entities
{
    public sealed class LeadStatus : BaseEntity
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
    }
}
