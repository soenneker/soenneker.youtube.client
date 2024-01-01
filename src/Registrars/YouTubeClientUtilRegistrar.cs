using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
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
    public static void AddYouTubeClientUtilAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IYouTubeClientUtil, YouTubeClientUtil>();
    }

    /// <summary>
    /// Adds <see cref="IYouTubeClientUtil"/> as a scoped service. <para/>
    /// </summary>
    public static void AddYouTubeClientUtilAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IYouTubeClientUtil, YouTubeClientUtil>();
    }
}
