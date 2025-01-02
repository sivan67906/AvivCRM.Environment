using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Services
{
    public interface ILeadSourceService
    {
        Task<LeadSource> GetByLeadSourceNameAsync(string leadSource);
        Task<IEnumerable<LeadSource>> SearchLeadSourceByNameAsync(string leadSource);
        System.Threading.Tasks.Task UpdateLeadSourceAsync(LeadSource leadSource);
    }
}
 