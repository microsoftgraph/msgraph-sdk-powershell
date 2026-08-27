using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Xunit;

namespace Microsoft.Graph.Wrapper.Runtime.Tests;

// The cache contract the Authentication module's session lifecycle demands: reconnect,
// Set-MgRequestContext and disconnect all replace the session HttpClient instance, so the
// adapter must follow the client's REFERENCE identity - same client reuses the adapter, a new
// client gets a new adapter. A cache without the key check kept serving the pre-reconnect
// adapter; that demonstrated failure is what these tests pin.
public sealed class SessionAdapterCacheTests
{
    [Fact]
    public void SameClientReturnsSameAdapter()
    {
        var client = new HttpClient();

        var first = SessionAdapterCache.GetOrCreate(client);
        var second = SessionAdapterCache.GetOrCreate(client);

        Assert.Same(first, second);
    }

    [Fact]
    public void ReplacedClientReturnsNewAdapter()
    {
        var clientA = new HttpClient();
        var clientB = new HttpClient();

        var adapterA = SessionAdapterCache.GetOrCreate(clientA);
        var adapterB = SessionAdapterCache.GetOrCreate(clientB);

        Assert.NotSame(adapterA, adapterB);
    }

    [Fact]
    public void ReturningToACachedKeyStillRebuilds()
    {
        // Single-slot cache: A -> B evicts A's adapter, so A afterwards gets a fresh one.
        // Correctness only requires never serving an adapter for the WRONG client.
        var clientA = new HttpClient();
        var clientB = new HttpClient();

        var adapterA1 = SessionAdapterCache.GetOrCreate(clientA);
        SessionAdapterCache.GetOrCreate(clientB);
        var adapterA2 = SessionAdapterCache.GetOrCreate(clientA);

        Assert.NotSame(adapterA1, adapterA2);
    }
}
