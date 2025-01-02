using MediatR;

namespace AvivCRM.Environment.Application.Features.Currencies.DeleteCurrency;
public class DeleteCurrencyCommand : IRequest
{
    public Guid Id { get; set; }
}
