using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.BillOrders.CreateBillOrder;
public class CreateBillOrderCommandHandler : IRequestHandler<CreateBillOrderCommand, Guid>
{
    private readonly IGenericRepository<BillOrder> _billOrdersRepository;
    public CreateBillOrderCommandHandler(IGenericRepository<BillOrder> billOrdersRepository)
    {
        _billOrdersRepository = billOrdersRepository;
    }

    public async Task<Guid> Handle(CreateBillOrderCommand request, CancellationToken cancellationToken)
    {
        var billOrder = new BillOrder
        {
            BillOrderPrefix = request.BillOrderPrefix,
            BillOrderNumberSeperater = request.BillOrderNumberSeperater,
            BillOrderNumberDigits = request.BillOrderNumberDigits,
            BillOrderNumberExample = request.BillOrderNumberExample,

        };
        await _billOrdersRepository.CreateAsync(billOrder);
        return billOrder.Id;
    }
}
