namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    /// <summary>
    /// Request to remove association between service principal and preapproval policy.
    /// </summary>
    internal class RemoveAssociationBetweenServicePrincipalAndPreapprovalPolicyRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The service principal Id.
        /// </summary>
        private string servicePrincipalId;

        /// <summary>
        /// The pre approval policy Id.
        /// </summary>
        private string permissionGrantPreApprovalPolicyId;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveAssociationBetweenServicePrincipalAndPreapprovalPolicyRequest"/> class.
        /// </summary>
        internal RemoveAssociationBetweenServicePrincipalAndPreapprovalPolicyRequest(
            string servicePrincipalId,
            string permissionGrantPreApprovalPolicyId)
        {
            this.servicePrincipalId = servicePrincipalId;
            this.permissionGrantPreApprovalPolicyId = permissionGrantPreApprovalPolicyId;
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
            return $"https://graph.microsoft.com/beta/servicePrincipals/{this.servicePrincipalId}/permissionGrantPreApprovalPolicies/{this.permissionGrantPreApprovalPolicyId}/$ref";
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
