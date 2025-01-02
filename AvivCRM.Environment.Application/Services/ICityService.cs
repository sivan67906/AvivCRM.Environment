using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Services;

public interface ICityService
{
    Task<IEnumerable<City>> GetCitiesByParentId(Guid stateId);
}

