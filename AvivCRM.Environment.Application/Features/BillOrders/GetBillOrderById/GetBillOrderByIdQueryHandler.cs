using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.BillOrders.GetBillOrderById;
public class GetBillOrderByIdQueryHandler : IRequestHandler<GetBillOrderByIdQuery, BillOrderDTO>
{
    private readonly IGenericRepository<BillOrder> _billorderrepo;
    public GetBillOrderByIdQueryHandler(IGenericRepository<BillOrder> billorderrepo)
    {
        _billorderrepo = billorderrepo;
    }

    public async Task<BillOrderDTO> Handle(GetBillOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var bill = await _billorderrepo.GetByIdAsync(request.Id);
        if (bill == null) return null;
        return new BillOrderDTO
        {
            Id = bill.Id,
            BillOrderPrefix = bill.BillOrderPrefix,
            BillOrderNumberSeperater = bill.BillOrderNumberSeperater,
            BillOrderNumberDigits = bill.BillOrderNumberDigits,
            BillOrderNumberExample = bill.BillOrderNumberExample,
        };
    }
}
