using MedicalSystem.Data;
using MedicalSystem.Data.Models;
using MedicalSystem.Model.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds the data services.
    /// </summary>
    /// <param name="serviceCollection">The service collection.</param>
    /// <param name="configuration">The configuration.</param>
    /// <returns></returns>
    public static IServiceCollection AddDataServices(
        this IServiceCollection serviceCollection, 
        IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(nameof(serviceCollection));
        ArgumentNullException.ThrowIfNull(nameof(configuration));

        serviceCollection.AddDbContext<MedicalSystemDbContext>(
            option => option.UseNpgsql(configuration.GetConnectionString("DbConnection")));

        //Repositories
        serviceCollection.AddScoped<IRepository<User>, Repository<User>>();

        return serviceCollection;
    }
}
