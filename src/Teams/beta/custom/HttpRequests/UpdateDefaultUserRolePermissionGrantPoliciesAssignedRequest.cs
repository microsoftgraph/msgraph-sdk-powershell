namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;
    using Microsoft.Graph.Beta.PowerShell.Runtime.Json;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request to update permission grant polcies assigned to default user role.
    /// </summary>
    internal class UpdateDefaultUserRolePermissionGrantPoliciesAssignedRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The permission grant policies to be assigned.
        /// </summary>
        private IEnumerable<string> permissionGrantPolicies;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePermissionGrantPreApprovalPolicyRequest"/> class.
        /// </summary>
        internal UpdateDefaultUserRolePermissionGrantPoliciesAssignedRequest(IEnumerable<string> permissionGrantPolicies)
        {
            this.permissionGrantPolicies = permissionGrantPolicies;
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
            return $"https://graph.microsoft.com/v1.0/policies/authorizationPolicy";
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
                            "defaultUserRolePermissions",
                            new JsonObject(
                                new Dictionary<string, JsonNode>
                                {
                                    {
                                        "permissionGrantPoliciesAssigned",
                                        JsonArray.Create(this.permissionGrantPolicies.ToArray())
                                    }
                                })
                        }
                    });
            return body;
        }
    }
}
