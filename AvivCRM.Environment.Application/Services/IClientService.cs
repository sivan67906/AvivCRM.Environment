using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Services
{
    public interface IClientService
    {
        Task<Client> GetByLeadAgentNameAsync(string client);
        Task<IEnumerable<Client>> SearchLeadAgentByNameAsync(string client);
        System.Threading.Tasks.Task UpdateLeadAgentAsync(Client client);
    }
}
