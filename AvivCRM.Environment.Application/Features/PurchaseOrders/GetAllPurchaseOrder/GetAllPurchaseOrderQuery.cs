using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.GetAllPurchaseOrder;
public class GetAllPurchaseOrderQuery : IRequest<IEnumerable<PurchaseOrderDTO>>
{
}
