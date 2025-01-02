using MediatR;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.CreateVendorcredit;
public class CreateVendorCreditCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? VendorCreditPrefix { get; set; }
    public string? VendorCreditNumberSeperater { get; set; }
    public string? VendorCreditNumberDigits { get; set; }
    public string? VendorCreditNumberExample { get; set; }
}
