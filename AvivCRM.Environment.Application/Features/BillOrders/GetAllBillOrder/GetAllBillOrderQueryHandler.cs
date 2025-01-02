using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.BillOrders.GetAllBillOrder;
public class GetAllBillOrderQueryHandler : IRequestHandler<GetAllBillOrderQuery, IEnumerable<BillOrderDTO>>
{
    private readonly IGenericRepository<BillOrder> _billorderrepository;
    public GetAllBillOrderQueryHandler(IGenericRepository<BillOrder> billorderrepository)
    {
        _billorderrepository = billorderrepository;
    }

    public async Task<IEnumerable<BillOrderDTO>> Handle(GetAllBillOrderQuery request, CancellationToken cancellationToken)
    {
        var billOrders = await _billorderrepository.GetAllAsync();

        var billlist = billOrders.Select(x => new BillOrderDTO
        {
            Id = x.Id,
            BillOrderPrefix = x.BillOrderPrefix,
            BillOrderNumberSeperater = x.BillOrderNumberSeperater,
            BillOrderNumberDigits = x.BillOrderNumberDigits,
            BillOrderNumberExample = x.BillOrderNumberExample,
        }).ToList();

        return billlist;
    }
}
