using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Infrastructure.Services;

public class StateService(IGenericRepository<State> stateRepository)
    : IStateService
{
    public async Task<IEnumerable<State>> GetStatesByParentId(Guid countryId)
    {
        var states = await stateRepository.GetAllAsync();
        var finalStateList = states.Where(x => x.CountryId == countryId && x.IsActive == true);
        return finalStateList;
    }
}

