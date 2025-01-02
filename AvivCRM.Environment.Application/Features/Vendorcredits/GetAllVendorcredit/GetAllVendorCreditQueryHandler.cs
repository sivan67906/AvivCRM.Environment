using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.GetAllVendorcredit;
public class GetAllVendorCreditQueryHandler : IRequestHandler<GetAllVendorCreditQuery, IEnumerable<VendorCreditDTO>>
{
    private readonly IGenericRepository<VendorCredit> _vendorrepo;
    public GetAllVendorCreditQueryHandler(IGenericRepository<VendorCredit> vendorrepo)
    {
        _vendorrepo = vendorrepo;
    }

    public async Task<IEnumerable<VendorCreditDTO>> Handle(GetAllVendorCreditQuery request, CancellationToken cancellationToken)
    {
        var clients = await _vendorrepo.GetAllAsync();

        var clientlist = clients.Select(x => new VendorCreditDTO
        {
            Id = x.Id,
            VendorCreditPrefix = x.VendorCreditPrefix,
            VendorCreditNumberSeperater = x.VendorCreditNumberSeperater,
            VendorCreditNumberDigits = x.VendorCreditNumberDigits,
            VendorCreditNumberExample = x.VendorCreditNumberExample,
        }).ToList();

        return clientlist;
    }
}
