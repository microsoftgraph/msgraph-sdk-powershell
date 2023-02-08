namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to get service principal.
    /// </summary>
    internal class GetServicePrincipalRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The AAD app id.
        /// </summary>
        private string azureAdAppId;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetServicePrincipalRequest"/> class.
        /// </summary>
        /// <param name="azureAdAppId">The AAd app Id.</param>
        internal GetServicePrincipalRequest(string azureAdAppId)
        {
            this.azureAdAppId = azureAdAppId;
        }

        /// <summary>
        /// Gets the Http method for the request.
        /// </summary>
        /// <returns>The http method.</returns>
        protected override System.Net.Http.HttpMethod GetHttpMethod()
        {
            return Runtime.Method.Get;
        }

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected override string GetBaseUrl()
        {
            return $"https://graph.microsoft.com/beta/servicePrincipals/appId={this.azureAdAppId}";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            return null;
        }
    }
}
