using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.UpdateVendorcredit;
public class UpdateVendorCreditCommandHandler : IRequestHandler<UpdateVendorCreditCommand, Guid>
{
    private readonly IGenericRepository<VendorCredit> _repository;
    public UpdateVendorCreditCommandHandler(IGenericRepository<VendorCredit> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(UpdateVendorCreditCommand request, CancellationToken cancellationToken)
    {
        var vendor = new VendorCredit
        {
            Id = request.Id,
            VendorCreditPrefix = request.VendorCreditPrefix,
            VendorCreditNumberSeperater = request.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = request.VendorCreditNumberDigits,
            VendorCreditNumberExample = request.VendorCreditNumberExample,
        };
        await _repository.UpdateAsync(vendor);
        return request.Id;
    }
}
