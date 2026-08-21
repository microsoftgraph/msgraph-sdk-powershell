#nullable enable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Microsoft.Graph.Wrapper.Runtime
{
    // Minimal IAuthenticationProvider for the -AccessToken path: just stamps the bearer header
    // Kiota's own request-adapter pipeline expects, no token acquisition/refresh. The header
    // rides on the per-request RequestInformation, never on the HttpClient, which is what lets
    // one shared HttpClient serve different tokens without bleed.
    internal sealed class StaticBearerTokenAuthenticationProvider : IAuthenticationProvider
    {
        private readonly string _token;

        public StaticBearerTokenAuthenticationProvider(string token)
        {
            _token = token.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase)
                ? token.Substring(7)
                : token;
        }

        public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
        {
            request.Headers.TryAdd("Authorization", $"Bearer {_token}");
            return Task.CompletedTask;
        }
    }
}
