using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Currencies.GetAllCurrencies;
public class GetAllCurrencyQueryHandler : IRequestHandler<GetAllCurrencyQuery, IEnumerable<CurrencyDTO>>
{
    private readonly IGenericRepository<Currency> _currencyRepository;

    public GetAllCurrencyQueryHandler(IGenericRepository<Currency> currencyRepository) => _currencyRepository = currencyRepository;

    async Task<IEnumerable<CurrencyDTO>> IRequestHandler<GetAllCurrencyQuery, IEnumerable<CurrencyDTO>>.Handle(GetAllCurrencyQuery request, CancellationToken cancellationToken)
    {
        var currencys = await _currencyRepository.GetAllAsync();

        var currencylist = currencys.Select(x => new CurrencyDTO
        {
            Id = x.Id,
            CurrencyName = x.CurrencyName,
            CurrencySymbol = x.CurrencySymbol,
            CurrencyCode = x.CurrencyCode,
            IsCryptocurrency = x.IsCryptocurrency,
            USDPrice = x.USDPrice,
            ExchangeRate = x.ExchangeRate,

            CurrencyPosition = x.CurrencyPosition,
            ThousandSeparator = x.ThousandSeparator,

            DecimalSeparator = x.DecimalSeparator,
            NumberofDecimals = x.NumberofDecimals,
        }).ToList();

        return currencylist;
    }
}
