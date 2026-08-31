using System;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Soenneker.YouTube.Client.Abstract;

/// <summary>
/// Provides a lazily created YouTubeExplode client over an owned cached HTTP client.
/// </summary>
public interface IYouTubeClientUtil : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the cached YouTubeExplode client.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>The YouTubeExplode client.</returns>
    ValueTask<YoutubeClient> Get(CancellationToken cancellationToken = default);
}
