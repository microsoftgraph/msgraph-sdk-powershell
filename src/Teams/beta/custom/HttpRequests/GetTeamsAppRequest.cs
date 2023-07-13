namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to get Teams app.
    /// </summary>
    internal class GetTeamsAppRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The teams app Id.
        /// </summary>
        private string teamsAppId;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamsAppRequest"/> class.
        /// </summary>
        internal GetTeamsAppRequest(string teamsAppId)
        {
            this.teamsAppId = teamsAppId;
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
            return $"https://graph.microsoft.com/beta/appCatalogs/teamsApps/{this.teamsAppId}?$expand=appDefinitions";
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
