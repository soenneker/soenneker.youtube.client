[![](https://img.shields.io/nuget/v/soenneker.youtube.client.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.youtube.client/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.youtube.client/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.youtube.client/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.youtube.client.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.youtube.client/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.youtube.client/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.youtube.client/actions/workflows/codeql.yml)

# Soenneker.YouTube.Client

Provides a lazily created `YoutubeExplode.YoutubeClient` for reading public YouTube metadata and media streams.

## Install

```shell
dotnet add package Soenneker.YouTube.Client
```

## Registration

```csharp
using Soenneker.YouTube.Client.Registrars;
services.AddYouTubeClientUtilAsSingleton();
```

Scoped registration is also available:

```csharp
services.AddYouTubeClientUtilAsScoped();
```

Each provider owns its cached HTTP client. Scoped providers use independent cache entries, so disposing one scope does not remove another scope's client.

## Usage

```csharp
public sealed class VideoReader
{
    private readonly IYouTubeClientUtil _youtube;

    public VideoReader(IYouTubeClientUtil youtube)
    {
        _youtube = youtube;
    }

    public async Task PrintTitle(string videoUrl, CancellationToken cancellationToken)
    {
        YoutubeClient client = await _youtube.Get(cancellationToken);
        var video = await client.Videos.GetAsync(videoUrl, cancellationToken);

        Console.WriteLine($"{video.Title} — {video.Author.ChannelTitle}");
    }
}
```

The package does not use the official YouTube Data API and does not require an API key. Behavior follows YouTubeExplode and can be affected by changes to YouTube's public site.
