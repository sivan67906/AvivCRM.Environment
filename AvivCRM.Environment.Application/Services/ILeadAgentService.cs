using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Services
{
    public interface ILeadAgentService
    {
        Task<LeadAgent> GetByLeadAgentNameAsync(string leadAgent);
        Task<IEnumerable<LeadAgent>> SearchLeadAgentByNameAsync(string leadAgent);
        System.Threading.Tasks.Task UpdateLeadAgentAsync(LeadAgent agent);
    }
}
