namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal.Requests
{
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;

    /// <summary>
    /// Request to update group consent settings.
    /// </summary>
    internal class UpdateGroupConsentSettingsRequest : TeamsHttpRequest
    {
        /// <summary>
        /// The setting Id.
        /// </summary>
        private string settingId;

        /// <summary>
        /// The group consent setting values.
        /// </summary>
        private MGTeamsInternalTenantConsentSettingValue[] groupConsentSettingValues;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupConsentSettingsRequest"/> class.
        /// </summary>
        internal UpdateGroupConsentSettingsRequest(string settingId, MGTeamsInternalTenantConsentSettingValue[] groupConsentSettingValues)
        {
            this.settingId = settingId;
            this.groupConsentSettingValues = groupConsentSettingValues;
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
            return $"https://graph.microsoft.com/beta/settings/{this.settingId}";
        }

        /// <summary>
        /// Gets the body of the request as a string.
        /// </summary>
        /// <returns>The body.</returns>
        protected override string GetBodyAsString()
        {
            return new MGTeamsInternalTenantConsentSettings(templateId: null, consentSettingValues: groupConsentSettingValues).ToJson();
        }
    }
}
