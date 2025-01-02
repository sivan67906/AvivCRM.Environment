using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.BillOrders.GetAllBillOrder;
public class GetAllBillOrderQuery : IRequest<IEnumerable<BillOrderDTO>>
{

}
