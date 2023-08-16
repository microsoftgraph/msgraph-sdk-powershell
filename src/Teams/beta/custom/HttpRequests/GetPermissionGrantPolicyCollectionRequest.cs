using System.Text;

namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to get all permission grant policies in the tenant.
    /// </summary>
    internal class GetPermissionGrantPolicyCollectionRequest : TeamsHttpRequest
    {
        /// <summary>
        /// Select query.
        /// </summary>
        private readonly string selectQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPermissionGrantPolicyCollectionRequest"/> class.
        /// </summary>
        /// <param name="servicePrincipalId">The service principal Id.</param>
        internal GetPermissionGrantPolicyCollectionRequest(string selectQuery)
        {
            this.selectQuery = selectQuery;
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
            StringBuilder sb = new StringBuilder();
            sb.Append("https://graph.microsoft.com/beta/policies/permissiongrantpolicies");
            if (this.selectQuery != null)
            {
                sb.Append($"?$select={this.selectQuery}");
            }

            return sb.ToString();
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
