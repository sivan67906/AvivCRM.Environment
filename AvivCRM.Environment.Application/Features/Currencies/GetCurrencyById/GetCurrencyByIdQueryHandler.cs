using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Currencies.GetCurrencyById;
public class GetCurrencyByIdQueryHandler : IRequestHandler<GetCurrencyByIdQuery, CurrencyDTO>
{
    private readonly IGenericRepository<Currency> _currencyRepo;
    public GetCurrencyByIdQueryHandler(IGenericRepository<Currency> currencyRepo) => _currencyRepo = currencyRepo;

    public async Task<CurrencyDTO> Handle(GetCurrencyByIdQuery request, CancellationToken cancellationToken)
    {
        var currency = await _currencyRepo.GetByIdAsync(request.Id);
        if (currency == null) return null;
        return new CurrencyDTO
        {
            Id = currency.Id,
            CurrencyName = currency.CurrencyName,
            CurrencySymbol = currency.CurrencySymbol,
            CurrencyCode = currency.CurrencyCode,
            IsCryptocurrency = currency.IsCryptocurrency,
            USDPrice = currency.USDPrice,
            ExchangeRate = currency.ExchangeRate,

            CurrencyPosition = currency.CurrencyPosition,
            ThousandSeparator = currency.ThousandSeparator,

            DecimalSeparator = currency.DecimalSeparator,
            NumberofDecimals = currency.NumberofDecimals,
        };
    }
}
