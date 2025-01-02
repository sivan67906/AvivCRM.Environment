using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace ConfigurationServices.CQRS.Infrastucture.Services
{
    public class LeadSourceService : ILeadSourceService
    {
        private readonly IGenericRepository<LeadSource> _leadRepository;

        public LeadSourceService(IGenericRepository<LeadSource> leadRepository)
        {
            _leadRepository = leadRepository;
        }
        public async Task<LeadSource> GetByLeadSourceNameAsync(string leadSource)
        {
            var lead = await _leadRepository.GetAllAsync();
            return lead.FirstOrDefault(p => p.Name.Equals(leadSource, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<LeadSource>> SearchLeadSourceByNameAsync(string leadSource)
        {
            var leads = await _leadRepository.GetAllAsync();
            return leads.Where(p => p.Name.Contains(leadSource, StringComparison.OrdinalIgnoreCase));
        }

        public async System.Threading.Tasks.Task UpdateLeadSourceAsync(LeadSource leadSource)
        {
            var existingProduct = await _leadRepository.GetByIdAsync(leadSource.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {leadSource.Id} not found.");
            }

            // Detach the existing product to avoid tracking conflict
            //_productRepository.Detach(existingProduct);

            // Apply changes to the product
            existingProduct.Name = leadSource.Name;

            // Call the repository's UpdateAsync method
            await _leadRepository.UpdateAsync(existingProduct);
        }
    }
}
