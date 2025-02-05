using System;
using Soenneker.Utils.AsyncSingleton;
using Soenneker.YouTube.Client.Abstract;
using System.Net.Http;
using System.Threading.Tasks;
using YoutubeExplode;
using Microsoft.Extensions.Logging;
using Soenneker.Utils.HttpClientCache.Abstract;
using System.Threading;
using Soenneker.Extensions.ValueTask;

namespace Soenneker.YouTube.Client;

/// <inheritdoc cref="IYouTubeClientUtil"/>
public class YouTubeClientUtil: IYouTubeClientUtil
{
    private readonly AsyncSingleton<YoutubeClient> _client;
    private readonly IHttpClientCache _httpClientCache;

    public YouTubeClientUtil(ILogger<YouTubeClientUtil> logger, IHttpClientCache httpClientCache)
    {
        _httpClientCache = httpClientCache;

        _client = new AsyncSingleton<YoutubeClient>(async (cancellationToken, _) =>
        {
            logger.LogInformation("Connecting to YouTube...");

            HttpClient httpClient = await _httpClientCache.Get(nameof(YouTubeClientUtil), cancellationToken: cancellationToken).NoSync();

            return new YoutubeClient(httpClient);
        });
    }

    public ValueTask<YoutubeClient> Get(CancellationToken cancellationToken = default)
    {
        return _client.Get(cancellationToken);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);

        _client.Dispose();

        _httpClientCache.RemoveSync(nameof(YouTubeClientUtil));
    }

    public async ValueTask DisposeAsync()
    {
        GC.SuppressFinalize(this);

        await _client.DisposeAsync().NoSync();

        await _httpClientCache.Remove(nameof(YouTubeClientUtil)).NoSync();
    }
}
