using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Purchases.GetAllPurchase;
public class GetAllPurchaseQuery : IRequest<IEnumerable<PurchaseDTO>>
{
}
