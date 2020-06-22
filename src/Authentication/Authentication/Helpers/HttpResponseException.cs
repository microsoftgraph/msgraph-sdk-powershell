using System.Net.Http;

namespace Microsoft.Graph.PowerShell.Authentication.Helpers
{
    public sealed class HttpResponseException : HttpRequestException
    {
        /// <summary>
        /// Constructor for HttpResponseException.
        /// </summary>
        /// <param name="message">Message for the exception.</param>
        /// <param name="response">Response from the HTTP server.</param>
        public HttpResponseException(string message, HttpResponseMessage response) : base(message)
        {
            Response = response;
        }

        /// <summary>
        /// HTTP error response.
        /// </summary>
        public HttpResponseMessage Response { get; private set; }
    }
}