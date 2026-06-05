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
    /// Gets the value.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<YoutubeClient> Get(CancellationToken cancellationToken = default);
}
