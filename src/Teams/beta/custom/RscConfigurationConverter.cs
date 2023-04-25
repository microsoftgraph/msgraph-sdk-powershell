namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using Microsoft.Graph.Beta.PowerShell.Models;
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;
    using Microsoft.Graph.Beta.PowerShell.Runtime;
    using System;
    using System.Linq;

    /// <summary>
    /// RSC configuration converter.
    /// </summary>
    internal class RscConfigurationConverter
    {
        internal const string MicrosoftCreatedPermissionGrantPolicyForChatRscPreApproval = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-chat";

        internal const string MicrosoftCreatedPermissionGrantPolicyForTeamRscPreApproval = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-group";

        internal const string GroupConsentSettingsTemplateId = "dffd5d46-495d-40a9-8e21-954ff55e198a";

        internal const string EnableGroupSpecificConsentKey = "EnableGroupSpecificConsent";

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAppPreApprovalPolicyConverter"/> class.
        /// </summary>
        /// <param name="rscPermissionCollection">RSC permisssion collection.</param>
        internal RscConfigurationConverter()
        {
        }

        /// <summary>
        /// Convert the given set of conditions to a permission grant preapproval policy.
        /// </summary>
        /// <param name="resourceSpecificApplicationPermissionsAllowedForChats">RSC permissions allowed for chats.</param>
        /// <param name="teamLevelSensitivityLabelSelectionMode">Team level sensitivity label selection mode.</param>
        /// <param name="specificSensitivityLabelIdsApplicableToTeams">Specific sensitivity label ids applicable to teams.</param>
        /// <param name="resourceSpecificApplicationPermissionsAllowedForTeams">RSC permissions allowed for teams.</param>
        /// <returns>Task wrapping the preapproval policy.</returns>
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
                ?.Contains(RscConfigurationConverter.MicrosoftCreatedPermissionGrantPolicyForChatRscPreApproval, StringComparer.OrdinalIgnoreCase) == true)
            {
                this.LogVerbose("Authorization policy contains permission grant policy for chat RSC preapprovals.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
            }
            else
            {
                this.LogVerbose("Chat RSC is disabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Disabled;
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

            MGTeamsInternalTenantConsentSettings groupConsentSettings = tenantConsentSettingCollection.Value?.FirstOrDefault(
                v => string.Equals(v.TemplateId, RscConfigurationConverter.GroupConsentSettingsTemplateId, StringComparison.OrdinalIgnoreCase));

            if (groupConsentSettings == null)
            {
                this.LogVerbose("Group Consent settings were not found.", eventListener);
            }

            MGTeamsInternalTenantConsentSettingValue isGroupConsentEnabledSettingValue = groupConsentSettings?.Values?.SingleOrDefault(
                v => string.Equals(v.Name, RscConfigurationConverter.EnableGroupSpecificConsentKey, StringComparison.OrdinalIgnoreCase));

            if (string.Equals(isGroupConsentEnabledSettingValue?.Value, true.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                this.LogVerbose("Group consent setting value is enabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
            }
            else if (authorizationPolicy
                ?.DefaultUserRolePermissions
                ?.PermissionGrantPoliciesAssigned
                ?.Contains(
                    RscConfigurationConverter.MicrosoftCreatedPermissionGrantPolicyForTeamRscPreApproval, StringComparer.OrdinalIgnoreCase) == true)
            {
                this.LogVerbose("Authorization policy contains permission grant policy for team RSC preapprovals.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
            }
            else
            {
                this.LogVerbose("Team RSC is disabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Disabled;
            }

            return microsoftGraphRscConfiguration;
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
