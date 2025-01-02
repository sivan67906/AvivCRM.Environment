using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Services
{
    public interface ILeadCategoryService
    {
        Task<LeadCategory> GetByCategoryNameAsync(string categoryName);
        Task<IEnumerable<LeadCategory>> SearchCategoryByNameAsync(string categoryName);
        System.Threading.Tasks.Task UpdateCategoryAsync(LeadCategory category);
    }
}
