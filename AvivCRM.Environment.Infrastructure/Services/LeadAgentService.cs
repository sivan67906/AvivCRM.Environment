using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Infrastructure.Services
{
    public class LeadAgentService : ILeadAgentService
    {
        private readonly IGenericRepository<Domain.Entities.LeadAgent> _leadAgentRepository;
        public LeadAgentService(IGenericRepository<Domain.Entities.LeadAgent> leadAgentRepository) => leadAgentRepository = _leadAgentRepository;

        public async Task<LeadAgent> GetByLeadAgentNameAsync(string leadAgent)
        {
            var product = await _leadAgentRepository.GetAllAsync();
            return product.FirstOrDefault(
                p => p.Name.Equals(leadAgent, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<LeadAgent>> SearchLeadAgentByNameAsync(string leadAgent)
        {
            var products = await _leadAgentRepository.GetAllAsync();
            return products.Where(
                p => p.Name.Contains(leadAgent, StringComparison.OrdinalIgnoreCase));
        }

        public async System.Threading.Tasks.Task UpdateLeadAgentAsync(LeadAgent agent)
        {
            var existingProduct = await _leadAgentRepository.GetByIdAsync(agent.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {agent.Id} not found.");
            }

            // Detach the existing product to avoid tracking conflict
            //_productRepository.Detach(existingProduct);

            // Apply changes to the product
            existingProduct.Name = agent.Name;


            // Call the repository's UpdateAsync method
            await _leadAgentRepository.UpdateAsync(existingProduct);
        }
    }
}
