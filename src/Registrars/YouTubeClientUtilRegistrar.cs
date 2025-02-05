using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Utils.HttpClientCache.Registrar;
using Soenneker.YouTube.Client.Abstract;

namespace Soenneker.YouTube.Client.Registrars;

/// <summary>
/// An async thread-safe singleton for the YouTube client YouTubeExplode
/// </summary>
public static class YouTubeClientUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IYouTubeClientUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddYouTubeClientUtilAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton();
        services.TryAddSingleton<IYouTubeClientUtil, YouTubeClientUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IYouTubeClientUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddYouTubeClientUtilAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton();
        services.TryAddScoped<IYouTubeClientUtil, YouTubeClientUtil>();

        return services;
    }
}