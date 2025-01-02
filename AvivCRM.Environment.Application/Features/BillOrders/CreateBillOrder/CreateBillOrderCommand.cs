using MediatR;

namespace AvivCRM.Environment.Application.Features.BillOrders.CreateBillOrder;
public class CreateBillOrderCommand : IRequest<Guid>
{

    public string? BillOrderPrefix { get; set; }
    public string? BillOrderNumberSeperater { get; set; }
    public string? BillOrderNumberDigits { get; set; }
    public string? BillOrderNumberExample { get; set; }
}
