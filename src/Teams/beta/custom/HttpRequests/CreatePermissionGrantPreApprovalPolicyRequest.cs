namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;

    /// <summary>
    /// Request to create the given permission grant pre approval policy.
    /// </summary>
    internal class CreatePermissionGrantPreApprovalPolicyRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The preapproval policy to be created.
        /// </summary>
        private MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicyToBeCreated;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePermissionGrantPreApprovalPolicyRequest"/> class.
        /// </summary>
        /// <param name="preApprovalPolicyToBeCreated">The preapproval policy to be created.</param>
        internal CreatePermissionGrantPreApprovalPolicyRequest(
            MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicyToBeCreated)
        {
            this.preApprovalPolicyToBeCreated = preApprovalPolicyToBeCreated;
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
            return $"https://graph.microsoft.com/beta/policies/permissionGrantPreApprovalPolicies";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            return preApprovalPolicyToBeCreated.ToJson();
        }
    }
}
