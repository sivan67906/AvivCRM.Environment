using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Infrastructure.Services;

public class CityService(IGenericRepository<City> cityRepository)
    : ICityService
{
    public async Task<IEnumerable<City>> GetCitiesByParentId(Guid stateId)
    {
        var cities = await cityRepository.GetAllAsync();
        return cities.Where(x => x.StateId == stateId && x.IsActive == true);
    }
}

