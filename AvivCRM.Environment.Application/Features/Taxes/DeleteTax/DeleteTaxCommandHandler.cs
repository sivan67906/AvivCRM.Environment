using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Taxes.DeleteTax;
public class DeleteTaxCommandHandler : IRequestHandler<DeleteTaxCommand>
{
    private readonly IGenericRepository<Tax> _taxRepository;
    public DeleteTaxCommandHandler(IGenericRepository<Tax> taxRepository) => _taxRepository = taxRepository;

    public async System.Threading.Tasks.Task Handle(DeleteTaxCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _taxRepository.DeleteAsync(request.Id);
    }
}
