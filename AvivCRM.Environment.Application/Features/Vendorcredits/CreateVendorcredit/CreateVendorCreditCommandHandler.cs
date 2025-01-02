using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.CreateVendorcredit;
public class CreateVendorCreditCommandHandler : IRequestHandler<CreateVendorCreditCommand, Guid>
{
    private readonly IGenericRepository<VendorCredit> _vendorrepo;
    public CreateVendorCreditCommandHandler(IGenericRepository<VendorCredit> vendorrepo)
    {
        _vendorrepo = vendorrepo;
    }

    public async Task<Guid> Handle(CreateVendorCreditCommand request, CancellationToken cancellationToken)
    {
        var client = new VendorCredit
        {
            VendorCreditPrefix = request.VendorCreditPrefix,
            VendorCreditNumberSeperater = request.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = request.VendorCreditNumberDigits,
            VendorCreditNumberExample = request.VendorCreditNumberExample,
        };
        await _vendorrepo.CreateAsync(client);
        return client.Id;
    }
}
