using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Application.Services;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Cities.GetCitiesByParentId;
public class GetCitiesByParentIdQueryHandler : IRequestHandler<GetCitiesByParentIdQuery, IEnumerable<CityDTO>>
{
    private readonly ICityService _cityService;

    public GetCitiesByParentIdQueryHandler(ICityService cityService)
    {
        _cityService = cityService;
    }
    public async Task<IEnumerable<CityDTO>> Handle(GetCitiesByParentIdQuery request, CancellationToken cancellationToken)
    {
        var cities = await _cityService.GetCitiesByParentId(request.StateId);
        if (cities == null || !cities.Any()) return null;

        var cityList = cities.Select(x => new CityDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            StateId = x.StateId,
            //CountryName = x.Countries.Name,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return cityList;
    }
}

