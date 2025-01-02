using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Currencies.GetAllCurrencies;
public class GetAllCurrencyQuery : IRequest<IEnumerable<CurrencyDTO>>
{
}
