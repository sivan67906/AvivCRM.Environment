namespace AvivCRM.Environment.Domain.Entities
{
    public sealed class LeadStatus
    {
        public Guid Id { get; set; }
        public string? Status { get; set; }
        public string? Color { get; set; }
    }
}
