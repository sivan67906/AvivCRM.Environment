﻿using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Domain.Contracts.Lead;
public interface ILeadSource
{
    void Add(LeadSource leadSource);
    void Update(LeadSource leadSource);
    void Delete(LeadSource leadSource);
    Task<LeadSource?> GetByIdAsync(Guid id);
    Task<IEnumerable<LeadSource>> GetAllAsync();
    Task<bool> IsAvailableByNameAsync(string leadCategoryName);
}
