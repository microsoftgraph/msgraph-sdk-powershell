namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using System;
    using System.Linq;
    using Microsoft.Graph.Beta.PowerShell.Models;
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;
    using Microsoft.Graph.Beta.PowerShell.Runtime;

    /// <summary>
    /// RSC configuration synthesizer.
    /// </summary>
    internal class RscConfigurationSynthesizer
    {
        internal const string MicrosoftCreatedPermissionGrantPolicyForChatRscPreApproval = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-chat";

        internal const string MicrosoftCreatedPermissionGrantPolicyForTeamRscPreApproval = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-group";

        internal const string MicrosoftCreatedPermissionGrantPolicyForUserConsentLegacy = "ManagePermissionGrantsForSelf.microsoft-user-default-legacy";

        internal const string GroupConsentSettingsTemplateId = "dffd5d46-495d-40a9-8e21-954ff55e198a";

        internal const string EnableGroupSpecificConsentKey = "EnableGroupSpecificConsent";

        /// <summary>
        /// Initializes a new instance of the <see cref="RscConfigurationSynthesizer"/> class.
        /// </summary>
        internal RscConfigurationSynthesizer()
        {
        }

        /// <summary>
        /// Convert the given settings and policy to Chat RSC configuration.
        /// </summary>
        /// <param name="teamsAppSettings">Teams app settings.</param>
        /// <param name="authorizationPolicy">Authorization policy.</param>
        /// <returns>The chat RSC configuration.</returns>
        internal MicrosoftGraphRscConfiguration ConvertToChatRscConfiguration(
            Models.IMicrosoftGraphTeamsAppSettings teamsAppSettings,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            Runtime.IEventListener eventListener)
        {
            if (teamsAppSettings == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "TeamsApp settings were not found.");
            }

            if (authorizationPolicy == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "Authorization policy was not found.");
            }

            MicrosoftGraphRscConfiguration microsoftGraphRscConfiguration = new MicrosoftGraphRscConfiguration
            {
                Id = "ChatResourceSpecificPermissionConfiguration",
                ScopeType = MicrosoftGraphRscConfigurationScopeType.Chat
            };

            if (teamsAppSettings.IsChatResourceSpecificConsentEnabled == true)
            {
                this.LogVerbose("Chat RSC is enabled in Teams App Settings.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
            }
            else if (authorizationPolicy
                ?.DefaultUserRolePermissions
                ?.PermissionGrantPoliciesAssigned
                ?.Contains(RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyForChatRscPreApproval, StringComparer.OrdinalIgnoreCase) == true)
            {
                this.LogVerbose("Authorization policy contains permission grant policy for chat RSC preapprovals.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
            }
            else
            {
                this.LogVerbose("Chat RSC is disabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.DisabledForAllApps;
            }

            return microsoftGraphRscConfiguration;
        }

        /// <summary>
        /// Convert the given tenant settings to Team RSC configuration.
        /// </summary>
        /// <param name="tenantConsentSettingCollection">Tenant consent setting collection.</param>
        /// <param name="authorizationPolicy">Authorization policy.</param>
        /// <returns>Rsc configuration.</returns>
        internal IMicrosoftGraphRscConfiguration ConvertToTeamRscConfiguration(
            MGTeamsInternalTenantConsentSettingsCollection tenantConsentSettingCollection,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            Runtime.IEventListener eventListener)
        {
            if (tenantConsentSettingCollection == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "Tenant consent settings were not found.");
            }

            if (authorizationPolicy == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "Authorization policy was not found.");
            }

            MicrosoftGraphRscConfiguration microsoftGraphRscConfiguration = new MicrosoftGraphRscConfiguration
            {
                Id = "TeamResourceSpecificPermissionConfiguration",
                ScopeType = MicrosoftGraphRscConfigurationScopeType.Team
            };

            string projectedIsGroupConsentEnabledSettingValue = this.GetProjectedIsGroupConsentEnabledSettingValue(
                tenantConsentSettingCollection,
                authorizationPolicy,
                eventListener);

            if (string.Equals(projectedIsGroupConsentEnabledSettingValue, true.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                this.LogVerbose("Group consent setting value is enabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
            }
            else if (authorizationPolicy
                ?.DefaultUserRolePermissions
                ?.PermissionGrantPoliciesAssigned
                ?.Contains(
                    RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyForTeamRscPreApproval, StringComparer.OrdinalIgnoreCase) == true)
            {
                this.LogVerbose("Authorization policy contains permission grant policy for team RSC preapprovals.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
            }
            else
            {
                this.LogVerbose("Team RSC is disabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.DisabledForAllApps;
            }

            return microsoftGraphRscConfiguration;
        }

        /// <summary>
        /// Get the projected value of IsGroupConsentEnabled.
        /// </summary>
        /// <param name="tenantConsentSettingCollection">Tenant consent setting collection.</param>
        /// <param name="authorizationPolicy">The authorization policy.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>Project value of IsGroupConsentEnabled.</returns>
        private string GetProjectedIsGroupConsentEnabledSettingValue(
            MGTeamsInternalTenantConsentSettingsCollection tenantConsentSettingCollection,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            IEventListener eventListener)
        {
            MGTeamsInternalTenantConsentSettings groupConsentSettings = tenantConsentSettingCollection.Value?.FirstOrDefault(
                v => string.Equals(v.TemplateId, RscConfigurationSynthesizer.GroupConsentSettingsTemplateId, StringComparison.OrdinalIgnoreCase));

            if (groupConsentSettings == null)
            {
                this.LogVerbose("Group Consent settings were not found.", eventListener);

                if (authorizationPolicy
                    ?.DefaultUserRolePermissions
                    ?.PermissionGrantPoliciesAssigned
                    ?.Contains(
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyForUserConsentLegacy, StringComparer.OrdinalIgnoreCase) == true)
                {
                    this.LogVerbose("Legacy policy for user consent was found in default user role permissions. Projecting group consent to be true.", eventListener);
                    return true.ToString();
                }

                return false.ToString();
            }

            MGTeamsInternalTenantConsentSettingValue isGroupConsentEnabledSettingValue = groupConsentSettings.Values?.SingleOrDefault(
                v => string.Equals(v.Name, RscConfigurationSynthesizer.EnableGroupSpecificConsentKey, StringComparison.OrdinalIgnoreCase));

            string projectedIsGroupConsentEnabledSettingValue = isGroupConsentEnabledSettingValue?.Value;
            return projectedIsGroupConsentEnabledSettingValue;
        }

        /// <summary>
        /// Log verbose.
        /// </summary>
        /// <param name="message">The log message.</param>
        /// <param name="eventListener">The event listener.</param>
        private void LogVerbose(string message, Runtime.IEventListener eventListener)
        {
            eventListener.Signal(
                Microsoft.Graph.Beta.PowerShell.Runtime.Events.Verbose,
                () => new Microsoft.Graph.Beta.PowerShell.Runtime.EventData
                {
                    Message = message,
                });
        }
    }
}
