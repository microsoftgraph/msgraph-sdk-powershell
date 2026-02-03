namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Runtime.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Request to update Teams App settings.
    /// </summary>
    internal class UpdateTeamsAppSettingsRequest : TeamsHttpRequest
    {
        /// <summary>
        /// Is Chat RSC enabled.
        /// </summary>
        private bool isChatResourceSpecificConsentEnabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTeamsAppSettingsRequest"/> class.
        /// </summary>
        internal UpdateTeamsAppSettingsRequest(bool isChatResourceSpecificConsentEnabled)
        {
            this.isChatResourceSpecificConsentEnabled = isChatResourceSpecificConsentEnabled;
        }

        /// <summary>
        /// Gets the Http method for the request.
        /// </summary>
        /// <returns>The http method.</returns>
        protected override System.Net.Http.HttpMethod GetHttpMethod()
        {
            return Runtime.Method.Patch;
        }

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected override string GetBaseUrl()
        {
            return $"https://graph.microsoft.com/beta/teamwork/teamsAppSettings";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            string body =
                new JsonObject(
                    new Dictionary<string, JsonNode>
                    {
                        {
                            "isChatResourceSpecificConsentEnabled",
                            new JsonBoolean(this.isChatResourceSpecificConsentEnabled)
                        }
                    });
            return body;
        }
    }
}
