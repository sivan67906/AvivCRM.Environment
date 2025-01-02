using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Cities.GetAllCities;

internal class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, IEnumerable<CityDTO>>
{
    private readonly IGenericRepository<City> _cityRepository;

    public GetAllCitiesQueryHandler(
        IGenericRepository<City> cityRepository) =>
        _cityRepository = cityRepository;

    public async Task<IEnumerable<CityDTO>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
    {
        var cities = await _cityRepository.GetAllAsync();

        var cityList = cities.Select(x => new CityDTO
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            StateId = x.StateId,
            CreatedDate = x.CreatedDate
        }).ToList();

        return cityList;
    }
}

















