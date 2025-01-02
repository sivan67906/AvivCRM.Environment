using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace ConfigurationServices.CQRS.Infrastucture.Services
{
    public class LeadStatusService : ILeadStatusService
    {
        private readonly IGenericRepository<LeadStatus> _leadstatusRepository;

        public LeadStatusService(IGenericRepository<LeadStatus> leadstatusRepository) 
        {
            _leadstatusRepository = leadstatusRepository;
        }

        public async Task<LeadStatus> GetByLeadStatusNameAsync(string leadStatus)
        {
            var lead = await _leadstatusRepository.GetAllAsync();
            return lead.FirstOrDefault(p => p.Status.Equals(leadStatus, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<LeadStatus>> SearchLeadStatusByNameAsync(string leadStatus)
        {
            var leads = await _leadstatusRepository.GetAllAsync();
            return leads.Where(p => p.Status.Contains(leadStatus, StringComparison.OrdinalIgnoreCase));
        }

        public async System.Threading.Tasks.Task UpdateLeadStatusAsync(LeadStatus leadStatus)
        {
            var existingProduct = await _leadstatusRepository.GetByIdAsync(leadStatus.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {leadStatus.Id} not found.");
            }

            // Detach the existing product to avoid tracking conflict
            //_productRepository.Detach(existingProduct);

            // Apply changes to the product
            existingProduct.Status = leadStatus.Status;
            existingProduct.Color = leadStatus.Color;

            // Call the repository's UpdateAsync method
            await _leadstatusRepository.UpdateAsync(existingProduct);
        }
    }
}
