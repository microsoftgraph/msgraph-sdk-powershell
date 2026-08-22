#nullable enable

using System.Net.Http;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.Wrapper.Runtime
{
    // One request adapter per session HttpClient, rebuilt exactly when the session client
    // changes. The Authentication module replaces its cached client on Connect-MgGraph,
    // Set-MgRequestContext and Disconnect-MgGraph (it nulls GraphSession.GraphHttpClient and the
    // next call builds a new one), so REFERENCE identity of the client is the correct cache key:
    // same client means the session is unchanged and the adapter is reusable; a different client
    // means reconnect/context change and the adapter must be rebuilt. A cache without this key
    // keeps serving an adapter bound to the pre-reconnect client - the stale-session bug this
    // class exists to prevent.
    internal static class SessionAdapterCache
    {
        private static readonly object Gate = new();
        private static HttpClient? _key;
        private static HttpClientRequestAdapter? _adapter;

        public static HttpClientRequestAdapter GetOrCreate(HttpClient sessionClient)
        {
            lock (Gate)
            {
                if (!ReferenceEquals(_key, sessionClient) || _adapter is null)
                {
                    // The session client carries the full auth handler pipeline, so the adapter
                    // itself authenticates nothing.
                    _adapter = new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: sessionClient);
                    _key = sessionClient;
                }

                return _adapter;
            }
        }
    }
}
