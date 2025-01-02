using System.Reflection;
using AvivCRM.Environment.Application.Common.AutoMapper;
using AvivCRM.Environment.Application.Features.LeadAgents.CreateLeadAgent;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AvivCRM.Environment.Application.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        services.AddValidatorsFromAssemblyContaining<CreateLeadCategoryCommandValidator>();
        services.AddAutoMapper(typeof(MapperConfig));
        return services;
        //services.AddValidatorsFromAssemblyContaining<>();
    }
}