using MedicalSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataServices(
        this IServiceCollection serviceCollection, 
        IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(nameof(serviceCollection));
        ArgumentNullException.ThrowIfNull(nameof(configuration));

        serviceCollection.AddDbContext<MedicalSystemDbContext>(
            option => option.UseNpgsql(configuration.GetConnectionString("DbConnection")));

        return serviceCollection;
    }
}
