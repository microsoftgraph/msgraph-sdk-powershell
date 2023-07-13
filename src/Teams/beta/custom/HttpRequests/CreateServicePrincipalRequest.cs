namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Runtime.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Request to create service principal.
    /// </summary>
    internal class CreateServicePrincipalRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The azure ad app id.
        /// </summary>
        private string azureAdAppId;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServicePrincipalRequest"/> class.
        /// </summary>
        /// <param name="azureAdAppId">The AAd app Id.</param>
        /// <param name="permissionGrantPreApprovalPolicyId">The preapproval policy Id.</param>
        internal CreateServicePrincipalRequest(string azureAdAppId)
        {
            this.azureAdAppId = azureAdAppId;
        }

        /// <summary>
        /// Gets the Http method for the request.
        /// </summary>
        /// <returns>The http method.</returns>
        protected override System.Net.Http.HttpMethod GetHttpMethod()
        {
            return Runtime.Method.Post;
        }

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected override string GetBaseUrl()
        {
            return $"https://graph.microsoft.com/beta/servicePrincipals";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            string body =
                new JsonObject(
                    new Dictionary<string, string>
                    {
                        {
                            "appId",
                            this.azureAdAppId
                        }
                    });
            return body;
        }
    }
}
