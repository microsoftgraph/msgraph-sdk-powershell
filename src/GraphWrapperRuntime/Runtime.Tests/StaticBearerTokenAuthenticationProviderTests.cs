using System.Linq;
using System.Threading.Tasks;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Kiota.Abstractions;
using Xunit;

namespace Microsoft.Graph.Wrapper.Runtime.Tests;

public sealed class StaticBearerTokenAuthenticationProviderTests
{
    [Fact]
    public async Task StampsBearerHeaderOnTheRequest()
    {
        var provider = new StaticBearerTokenAuthenticationProvider("tok-a");
        var request = new RequestInformation { UrlTemplate = "https://example/x" };

        await provider.AuthenticateRequestAsync(request);

        Assert.Equal("Bearer tok-a", Assert.Single(request.Headers["Authorization"]));
    }

    [Fact]
    public async Task StripsAnExistingBearerPrefix()
    {
        var provider = new StaticBearerTokenAuthenticationProvider("Bearer tok-b");
        var request = new RequestInformation { UrlTemplate = "https://example/x" };

        await provider.AuthenticateRequestAsync(request);

        Assert.Equal("Bearer tok-b", Assert.Single(request.Headers["Authorization"]));
    }

    [Fact]
    public async Task DifferentProvidersDoNotBleedAcrossRequests()
    {
        // The token rides the per-request RequestInformation, which is what lets one shared
        // HttpClient serve different tokens - the isolation the stub-transport experiment proved.
        var a = new StaticBearerTokenAuthenticationProvider("tok-a");
        var b = new StaticBearerTokenAuthenticationProvider("tok-b");
        var requestA = new RequestInformation { UrlTemplate = "https://example/a" };
        var requestB = new RequestInformation { UrlTemplate = "https://example/b" };

        await a.AuthenticateRequestAsync(requestA);
        await b.AuthenticateRequestAsync(requestB);

        Assert.Equal("Bearer tok-a", requestA.Headers["Authorization"].Single());
        Assert.Equal("Bearer tok-b", requestB.Headers["Authorization"].Single());
    }
}
