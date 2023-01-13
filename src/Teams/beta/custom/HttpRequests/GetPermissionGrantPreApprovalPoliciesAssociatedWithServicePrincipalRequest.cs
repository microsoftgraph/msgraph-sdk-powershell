namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to get permission grant pre approval policies associated with the service principal.
    /// </summary>
    internal class GetPermissionGrantPreApprovalPoliciesAssociatedWithServicePrincipalRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The service principal Id.
        /// </summary>
        private string servicePrincipalId;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPermissionGrantPreApprovalPoliciesAssociatedWithServicePrincipalRequest"/> class.
        /// </summary>
        /// <param name="servicePrincipalId">The service principal Id.</param>
        internal GetPermissionGrantPreApprovalPoliciesAssociatedWithServicePrincipalRequest(string servicePrincipalId)
        {
            this.servicePrincipalId = servicePrincipalId;
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
            return $"https://graph.microsoft.com/beta/servicePrincipals/{servicePrincipalId}/permissionGrantPreApprovalPolicies";
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
