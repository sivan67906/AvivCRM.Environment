using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Countries.UpdateCountry;

internal class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand>
{
    private readonly IGenericRepository<Country> _countryRepository;

    public UpdateCountryCommandHandler(
        IGenericRepository<Country> countryRepository) =>
        _countryRepository = countryRepository;

    public async System.Threading.Tasks.Task Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = new Country
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            UpdatedDate = request.UpdatedDate
        };

        await _countryRepository.UpdateAsync(country);
    }
}













