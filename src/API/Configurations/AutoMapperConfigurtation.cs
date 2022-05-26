using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace API.Configurations;

public static class AutoMapperConfiguration
{
    public static void AddAutoMapperConfiguration(this IServiceCollection services)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        var assemblies = new[] { Assembly.Load("AppServices") };

        services.AddAutoMapper((serviceProvider, mapperConfiguration) => mapperConfiguration.AddMaps(assemblies), assemblies);
    }
}
