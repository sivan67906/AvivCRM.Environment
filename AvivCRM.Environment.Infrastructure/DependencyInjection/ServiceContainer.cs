using ConfigurationServices.CQRS.Infrastucture.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Interfaces;
using AvivCRM.Environment.Infrastructure.Persistence;
using AvivCRM.Environment.Infrastructure.Repositories;
using AvivCRM.Environment.Infrastructure.Services;

namespace AvivCRM.Environment.Infrastructure.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EnvironmentDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("configurationSettingsCS")));

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ILeadAgentService, LeadAgentService>();
        services.AddScoped<ILeadCategoryService, LeadCategoryservice>();
        services.AddScoped<IClientService, ClientService>();
        services.AddScoped<ILeadSourceService, LeadSourceService>();
        services.AddScoped<ILeadStatusService, LeadStatusService>();
        services.AddScoped<IStateService, StateService>();
        services.AddScoped<ICityService, CityService>();

        return services;
    }
}
