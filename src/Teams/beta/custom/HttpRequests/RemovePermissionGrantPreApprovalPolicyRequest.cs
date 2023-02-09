namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to remove permission grant preapproval policy.
    /// </summary>
    internal class RemovePermissionGrantPreApprovalPolicyRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The policy id.
        /// </summary>
        private string policyId;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemovePermissionGrantPreApprovalPolicyRequest"/> class.
        /// </summary>
        internal RemovePermissionGrantPreApprovalPolicyRequest(string policyId)
        {
            this.policyId = policyId;
        }

        /// <summary>
        /// Gets the Http method for the request.
        /// </summary>
        /// <returns>The http method.</returns>
        protected override System.Net.Http.HttpMethod GetHttpMethod()
        {
            return Runtime.Method.Delete;
        }

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected override string GetBaseUrl()
        {
            return $"https://graph.microsoft.com/beta/policies/permissionGrantPreApprovalPolicies/{this.policyId}";
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
