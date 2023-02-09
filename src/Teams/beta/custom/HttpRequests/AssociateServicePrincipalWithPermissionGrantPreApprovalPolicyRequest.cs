namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Runtime.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Request to associate service principal with permission grant preapproval policy.
    /// </summary>
    internal class AssociateServicePrincipalWithPermissionGrantPreApprovalPolicyRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The service principal Id.
        /// </summary>
        private string servicePrincipalId;

        /// <summary>
        /// The permission grant preapproval policy id.
        /// </summary>
        private string permissionGrantPreApprovalPolicyId;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateServicePrincipalWithPermissionGrantPreApprovalPolicyRequest"/> class.
        /// </summary>
        /// <param name="servicePrincipalId">The service principal Id.</param>
        /// <param name="permissionGrantPreApprovalPolicyId">The preapproval policy Id.</param>
        internal AssociateServicePrincipalWithPermissionGrantPreApprovalPolicyRequest(
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
            return Runtime.Method.Post;
        }

        /// <summary>
        /// Gets the base url for the request.
        /// </summary>
        /// <returns>string containing the base url.</returns>
        protected override string GetBaseUrl()
        {
            return $"https://graph.microsoft.com/beta/servicePrincipals/{this.servicePrincipalId}/permissionGrantPreApprovalPolicies/$ref";
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
                            "@odata.id",
                            $"https://graph.microsoft.com/beta/policies/permissionGrantPreApprovalPolicies/{this.permissionGrantPreApprovalPolicyId}"
                        }
                    });
            return body;
        }
    }
}
