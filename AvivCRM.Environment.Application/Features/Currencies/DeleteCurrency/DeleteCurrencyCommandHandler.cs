using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Currencies.DeleteCurrency;
public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand>
{
    private readonly IGenericRepository<Currency> _currencyRepo;
    public DeleteCurrencyCommandHandler(IGenericRepository<Currency> currencyRepo) => _currencyRepo = currencyRepo;

    public async System.Threading.Tasks.Task Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _currencyRepo.DeleteAsync(request.Id);
    }
}
