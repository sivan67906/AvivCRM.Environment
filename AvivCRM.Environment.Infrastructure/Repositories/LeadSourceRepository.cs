//using Microsoft.EntityFrameworkCore;
using AvivCRM.Environment.Domain.Contracts.Lead;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Infrastructure.Persistence;

namespace AvivCRM.Environment.Infrastructure.Repositories;

public class LeadSourceRepository(EnvironmentDbContext dbContext)
    : GenericRepository<LeadSource>(dbContext, dbContext.LeadSources), ILeadSource
{

}
