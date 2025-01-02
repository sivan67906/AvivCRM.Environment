using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Services;

public interface IStateService
{
    Task<IEnumerable<State>> GetStatesByParentId(Guid countryId);
}

