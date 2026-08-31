using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Utils.HttpClientCache.Registrar;
using Soenneker.YouTube.Client.Abstract;

namespace Soenneker.YouTube.Client.Registrars;

/// <summary>
/// Registers the YouTubeExplode client provider.
/// </summary>
public static class YouTubeClientUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IYouTubeClientUtil"/> as a singleton service.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddYouTubeClientUtilAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton().TryAddSingleton<IYouTubeClientUtil, YouTubeClientUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IYouTubeClientUtil"/> as a scoped service while retaining the singleton HTTP client cache.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddYouTubeClientUtilAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton().TryAddScoped<IYouTubeClientUtil, YouTubeClientUtil>();

        return services;
    }
}
