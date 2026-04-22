using Soenneker.YouTube.Client.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.YouTube.Client.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class YouTubeClientUtilTests : HostedUnitTest
{
    private readonly IYouTubeClientUtil _util;

    public YouTubeClientUtilTests(Host host) : base(host)
    {
        _util = Resolve<IYouTubeClientUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
