namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Teams HTTP Request.
    /// </summary>
    internal abstract class TeamsHttpRequest
    {
        /// <summary>
        /// Get Http Request message for this instance.
        /// </summary>
        /// <returns>HTTP request message.</returns>
        internal System.Net.Http.HttpRequestMessage GetHttpRequestMessage()
        {
            string baseUrl = this.GetBaseUrl();
            var _url = new System.Uri(baseUrl);
            var request = new System.Net.Http.HttpRequestMessage(this.GetHttpMethod(), _url);

            // set body content
            var body = this.GetBodyAsString();
            if (body != null )
            {
                request.Content = new System.Net.Http.StringContent(body, System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
            }
            return request;
        }

        /// <summary>
        /// Gets the Http method for the request.
        /// </summary>
        /// <returns>The http method.</returns>
        protected abstract System.Net.Http.HttpMethod GetHttpMethod();

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected abstract string GetBaseUrl();

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected abstract string GetBodyAsString();
    }
}
