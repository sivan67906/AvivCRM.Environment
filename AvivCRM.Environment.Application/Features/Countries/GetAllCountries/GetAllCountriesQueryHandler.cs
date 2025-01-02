using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Countries.GetAllCountries;

internal class GetAllCountriesQueryHandler : IRequestHandler<GetAllCountriesQuery, IEnumerable<CountryDTO>>
{
    private readonly IGenericRepository<Country> _countryRepository;

    public GetAllCountriesQueryHandler(
        IGenericRepository<Country> countryRepository) =>
        _countryRepository = countryRepository;

    public async Task<IEnumerable<CountryDTO>> Handle(GetAllCountriesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _countryRepository.GetAllAsync();

        var countryList = companies.Select(x => new CountryDTO
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return countryList;
    }
}













