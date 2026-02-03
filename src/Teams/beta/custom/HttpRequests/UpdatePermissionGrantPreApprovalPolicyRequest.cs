namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;

    /// <summary>
    /// Request to update preapproval policy.
    /// </summary>
    internal class UpdatePermissionGrantPreApprovalPolicyRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The policy id.
        /// </summary>
        private string policyId;

        /// <summary>
        /// The policy contents.
        /// </summary>
        private MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicyToBeUpdated;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePermissionGrantPreApprovalPolicyRequest"/> class.
        /// </summary>
        internal UpdatePermissionGrantPreApprovalPolicyRequest(
            string policyId,
            MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicyToBeUpdated)
        {
            this.policyId = policyId;
            this.preApprovalPolicyToBeUpdated = preApprovalPolicyToBeUpdated;
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
            return $"https://graph.microsoft.com/beta/policies/permissionGrantPreApprovalPolicies/{this.policyId}";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            return preApprovalPolicyToBeUpdated.ToJson();
        }
    }
}
