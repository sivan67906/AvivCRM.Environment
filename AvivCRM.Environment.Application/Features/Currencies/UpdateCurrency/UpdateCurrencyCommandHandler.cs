using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Currencies.UpdateCurrency;
public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand, Guid>
{
    private readonly IGenericRepository<Currency> _currencyRepository;
    public UpdateCurrencyCommandHandler(IGenericRepository<Currency> currencyRepository) => _currencyRepository = currencyRepository;

    public async Task<Guid> Handle(UpdateCurrencyCommand request, CancellationToken cancellationToken)
    {
        var currency = new Currency
        {
            Id = request.Id,
            CurrencyName = request.CurrencyName,
            CurrencySymbol = request.CurrencySymbol,
            CurrencyCode = request.CurrencyCode,
            IsCryptocurrency = request.IsCryptocurrency,
            USDPrice = request.USDPrice,
            ExchangeRate = request.ExchangeRate,

            CurrencyPosition = request.CurrencyPosition,
            ThousandSeparator = request.ThousandSeparator,

            DecimalSeparator = request.DecimalSeparator,
            NumberofDecimals = request.NumberofDecimals,
        };
        await _currencyRepository.UpdateAsync(currency);
        return request.Id;
    }
}
