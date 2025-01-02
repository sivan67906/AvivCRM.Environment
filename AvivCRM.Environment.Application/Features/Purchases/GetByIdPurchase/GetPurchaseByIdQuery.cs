using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Purchases.GetByIdPurchase;
public class GetPurchaseByIdQuery : IRequest<PurchaseDTO>
{
    public Guid Id { get; set; }
}
