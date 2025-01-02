using MediatR;

namespace AvivCRM.Environment.Application.Features.Purchases.DeletePurchase;
public class DeletePurchaseCommand : IRequest
{
    public Guid Id { get; set; }
}
