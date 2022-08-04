using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace RDTasks.Domain;

public static class RDTasksDomainServiceCollectionExtensions
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}