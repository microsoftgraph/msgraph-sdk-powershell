using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    public class InvokeGraphRequestAuthProvider : IAuthenticationProvider
    {
        private readonly GraphRequestSession _session;

        public InvokeGraphRequestAuthProvider(GraphRequestSession session)
        {
            _session = session;
        }

        public Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            var authenticationHeader = new AuthenticationHeaderValue("Bearer", _session.Token);
            request.Headers.Authorization = authenticationHeader;
            return Task.CompletedTask;
        }
    }
}
