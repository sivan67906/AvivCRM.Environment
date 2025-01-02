using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Countries.DeleteCountry;

internal class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand>
{
    private readonly IGenericRepository<Country> _countryRepository;

    public DeleteCountryCommandHandler(
        IGenericRepository<Country> countryRepository) =>
        _countryRepository = countryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
    {
        await _countryRepository.DeleteAsync(request.Id);
    }
}













