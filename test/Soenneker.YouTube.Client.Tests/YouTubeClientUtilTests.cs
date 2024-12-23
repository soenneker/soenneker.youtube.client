using Soenneker.YouTube.Client.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.YouTube.Client.Tests;

[Collection("Collection")]
public class YouTubeClientUtilTests : FixturedUnitTest
{
    private readonly IYouTubeClientUtil _util;

    public YouTubeClientUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IYouTubeClientUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
