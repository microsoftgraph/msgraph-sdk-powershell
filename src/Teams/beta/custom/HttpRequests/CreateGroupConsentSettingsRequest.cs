namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;

    /// <summary>
    /// Request to create group consent settings.
    /// </summary>
    internal class CreateGroupConsentSettingsRequest : TeamsHttpRequest
    {
        /// <summary>
        /// Group consent setting values.
        /// </summary>
        private MGTeamsInternalTenantConsentSettingValue[] groupConsentSettingValues;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePermissionGrantPreApprovalPolicyRequest"/> class.
        /// </summary>
        /// <param name="preApprovalPolicyToBeCreated">The preapproval policy to be created.</param>
        internal CreateGroupConsentSettingsRequest(MGTeamsInternalTenantConsentSettingValue[] groupConsentSettingValues)
        {
            this.groupConsentSettingValues = groupConsentSettingValues;
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
            return new MGTeamsInternalTenantConsentSettings("dffd5d46-495d-40a9-8e21-954ff55e198a", groupConsentSettingValues).ToJson();
        }
    }
}
