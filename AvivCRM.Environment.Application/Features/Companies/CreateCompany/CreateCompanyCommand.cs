using MediatR;

namespace AvivCRM.Environment.Application.Features.Companies.CreateCompany;

public class CreateCompanyCommand : IRequest
{
    public string? Name { get; set; }
    public string? RegnNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int EstablishedYear { get; set; }
    public string? Website { get; set; }
    public Guid BusinessTypeId { get; set; }
    public Guid CategoryId { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; } = true;
}


