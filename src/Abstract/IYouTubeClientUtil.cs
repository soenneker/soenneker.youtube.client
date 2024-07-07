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
    ValueTask<YoutubeClient> Get(CancellationToken cancellationToken = default);
}
