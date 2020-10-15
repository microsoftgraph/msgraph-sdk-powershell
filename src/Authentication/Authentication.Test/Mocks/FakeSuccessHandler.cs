using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Graph.Authentication.Test
{
    internal class FakeSuccessHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                RequestMessage = request
            };
            return Task.FromResult(response);
        }
    }
}
