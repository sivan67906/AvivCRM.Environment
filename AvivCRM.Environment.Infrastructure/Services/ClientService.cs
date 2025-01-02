using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IGenericRepository<Client> _clientRepository;
        public ClientService(IGenericRepository<Client> clientRepository) => _clientRepository = clientRepository;

        public async Task<Client> GetByLeadAgentNameAsync(string client)
        {
            var product = await _clientRepository.GetAllAsync();
            return product.FirstOrDefault(
                p => p.ClientName.Equals(client, StringComparison.OrdinalIgnoreCase));
        }

        public async Task<IEnumerable<Client>> SearchLeadAgentByNameAsync(string client)
        {
            var products = await _clientRepository.GetAllAsync();
            return products.Where(
                p => p.ClientName.Contains(client, StringComparison.OrdinalIgnoreCase));
        }

        public async System.Threading.Tasks.Task UpdateLeadAgentAsync(Client client)
        {
            var existingProduct = await _clientRepository.GetByIdAsync(client.Id);

            if (existingProduct == null)
            {
                throw new KeyNotFoundException($"Product with ID {client.Id} not found.");
            }

            // Detach the existing product to avoid tracking conflict
            //_productRepository.Detach(existingProduct);

            // Apply changes to the product
            existingProduct.ClientName = client.ClientName;
            existingProduct.ClientCode = client.ClientCode;
            existingProduct.Description = client.Description;
            existingProduct.Email = client.Email;
            existingProduct.PhoneNumber = client.PhoneNumber;
            existingProduct.Company = client.Company;
            existingProduct.Address = client.Address;
            //existingProduct.Address2 = client.Address2;
            existingProduct.Country = client.Country;
            existingProduct.State = client.State;
            existingProduct.City = client.City;
            //existingProduct.ZipCode = client.ZipCode;

            // Call the repository's UpdateAsync method
            await _clientRepository.UpdateAsync(existingProduct);
        }
    }
}
