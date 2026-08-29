using System;
using System.Threading;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Soenneker.YouTube.Client.Abstract;

/// <summary>
/// An async thread-safe singleton for the YouTube client YouTubeExplode
/// </summary>
public interface IYouTubeClientUtil : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Returns the configured youtube Client used by the You Tube Client.
    /// </summary>
    /// <param name="cancellationToken">Token used to cancel the operation.</param>
    /// <returns>A task whose result is the requested youtube Client.</returns>
    ValueTask<YoutubeClient> Get(CancellationToken cancellationToken = default);
}
