using MediatR;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.DeleteVendorcredit;
public class DeleteVendorCreditCommand : IRequest
{
    public Guid Id { get; set; }
}
