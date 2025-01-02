using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.PurchaseOrders.GetPurchaseOrderById;
public class GetPurchaseOrderByIdQuery : IRequest<PurchaseOrderDTO>
{
    public Guid Id { get; set; }
}
