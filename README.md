[![](https://img.shields.io/nuget/v/soenneker.youtube.client.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.youtube.client/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.youtube.client/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.youtube.client/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.youtube.client.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.youtube.client/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.youtube.client/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.youtube.client/actions/workflows/codeql.yml)

# Soenneker.YouTube.Client

An async thread-safe singleton for the YouTube client YouTubeExplode.

## Install

```bash
dotnet add package Soenneker.YouTube.Client
```

## Quick start

```csharp
using Soenneker.YouTube.Client.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddYouTubeClientUtilAsSingleton();
```

Adds `IYouTubeClientUtil` as a singleton service.

## What you get

- `IYouTubeClientUtil` — An async thread-safe singleton for the YouTube client YouTubeExplode.
- `YouTubeClientUtilRegistrar` — An async thread-safe singleton for the YouTube client YouTubeExplode.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `YouTubeClientUtilRegistrar.AddYouTubeClientUtilAsSingleton(services)` | Adds `IYouTubeClientUtil` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `YouTubeClientUtilRegistrar.AddYouTubeClientUtilAsScoped(services)` | Adds `IYouTubeClientUtil` as a scoped service. | The same service collection, so additional registrations can be chained. |

## Practical notes

- Reuse the registered client instead of constructing one per operation.
- Calls that return a cached or singleton value reuse the same instance until the owning service is disposed.
- Dispose instances you own when their scope ends so held resources can be released.
