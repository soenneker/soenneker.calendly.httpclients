using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Calendly.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Calendly.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class CalendlyOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="CalendlyOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddCalendlyOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<ICalendlyOpenApiHttpClient, CalendlyOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="CalendlyOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddCalendlyOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<ICalendlyOpenApiHttpClient, CalendlyOpenApiHttpClient>();

        return services;
    }
}
