namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Graph.Beta.PowerShell.Cmdlets;
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

        internal const string ConstrainGroupSpecificConsentToMembersOfGroupIdKey = "ConstrainGroupSpecificConsentToMembersOfGroupId";

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
            MGTeamsInternalPermissionGrantPolicyCollection permissionGrantPolicyCollection,
            Models.IMicrosoftGraphTeamsAppSettings teamsAppSettings,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            Runtime.IEventListener eventListener)
        {
            if (permissionGrantPolicyCollection?.Value == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "Permission grant policies were not found.");
            }

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
                ScopeType = MicrosoftGraphRscConfigurationScopeType.Chat,
                State = MicrosoftGraphRscConfigurationState.Custom
            };

            IEnumerable<MGTeamsInternalPermissionGrantPolicy> assignedPermissionGrantPoliciesApplicableToChatScope =
                this.GetAssignedPermissionGrantPoliciesApplicableToGivenScopeType(
                    permissionGrantPolicyCollection,
                    authorizationPolicy,
                    MicrosoftGraphRscConfigurationScopeType.Chat);

            if (teamsAppSettings.IsChatResourceSpecificConsentEnabled == true)
            {
                if (assignedPermissionGrantPoliciesApplicableToChatScope.Any())
                {
                    this.LogVerbose(
                        "Chat RSC is enabled in Teams App Settings and chat scoped permission grant policies are enabled. Not a supported scenario.",
                        eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                }
                else
                {
                    this.LogVerbose("Chat RSC is enabled in Teams App Settings.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
                }
            }
            else if (assignedPermissionGrantPoliciesApplicableToChatScope.Any())
            {
                if (assignedPermissionGrantPoliciesApplicableToChatScope.Any(pgp => !string.Equals(
                        pgp.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyForChatRscPreApproval,
                        StringComparison.OrdinalIgnoreCase)))
                {
                    this.LogVerbose("Unknown chat scoped permission grant policies are enabled. Not a supported scenario.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                }
                else
                {
                    this.LogVerbose("Authorization policy contains permission grant policy for chat RSC preapprovals.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
                }
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
            MGTeamsInternalPermissionGrantPolicyCollection permissionGrantPolicyCollection,
            MGTeamsInternalTenantConsentSettingsCollection tenantConsentSettingCollection,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            Runtime.IEventListener eventListener)
        {
            if (permissionGrantPolicyCollection?.Value == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "Permission grant policies were not found.");
            }

            if (tenantConsentSettingCollection?.Value == null)
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
                ScopeType = MicrosoftGraphRscConfigurationScopeType.Team,
                State = MicrosoftGraphRscConfigurationState.Custom
            };

            (string isGroupConsentSettingEnabled, string groupConsentConstrainedToGroupId) projectedGroupConsentSettings = this.GetProjectedGroupConsentSettings(
                tenantConsentSettingCollection,
                authorizationPolicy,
                eventListener);

            IEnumerable<MGTeamsInternalPermissionGrantPolicy> assignedPermissionGrantPoliciesApplicableToGroupScope =
                this.GetAssignedPermissionGrantPoliciesApplicableToGivenScopeType(
                    permissionGrantPolicyCollection,
                    authorizationPolicy,
                    MicrosoftGraphRscConfigurationScopeType.Team);

            if (string.Equals(projectedGroupConsentSettings.isGroupConsentSettingEnabled, true.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                if (assignedPermissionGrantPoliciesApplicableToGroupScope.Any())
                {
                    this.LogVerbose(
                        "Projected group consent setting value is enabled and group scoped permission grant policies are enabled. Not a supported scenario.",
                        eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                }
                else if (string.IsNullOrWhiteSpace(projectedGroupConsentSettings.groupConsentConstrainedToGroupId))
                {
                    this.LogVerbose("Projected group consent setting value is enabled. No constraints on users able to grant consent.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
                }
                else
                {
                    this.LogVerbose($"Projected group consent setting value is enabled. Consent is constrained to users belonging to group '{projectedGroupConsentSettings.groupConsentConstrainedToGroupId}'.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForSelectedGroupOfUsers;
                }
            }
            else if (assignedPermissionGrantPoliciesApplicableToGroupScope.Any())
            {
                if (assignedPermissionGrantPoliciesApplicableToGroupScope.Any(pgp => !string.Equals(
                        pgp.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyForTeamRscPreApproval,
                        StringComparison.OrdinalIgnoreCase)))
                {
                    this.LogVerbose("Unknown group scoped permission grant policies are enabled. Not a supported scenario.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                }
                else
                {
                    this.LogVerbose("Authorization policy contains permission grant policy for team RSC preapprovals.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
                }
            }
            else
            {
                this.LogVerbose("Team RSC is disabled.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.DisabledForAllApps;
            }

            return microsoftGraphRscConfiguration;
        }

        internal IEnumerable<MGTeamsInternalPermissionGrantPolicy> GetAssignedPermissionGrantPoliciesApplicableToGivenScopeType(
            MGTeamsInternalPermissionGrantPolicyCollection permissionGrantPolicyCollection,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            MicrosoftGraphRscConfigurationScopeType rscConfigurationScopeType)
        {
            string identitySpecificScopeType;
            switch (rscConfigurationScopeType)
            {
                case MicrosoftGraphRscConfigurationScopeType.Team:
                    identitySpecificScopeType = "group";
                    break;

                case MicrosoftGraphRscConfigurationScopeType.Chat:
                    identitySpecificScopeType = "chat";
                    break;

                default:
                    throw new NotSupportedException();
            }

            IEnumerable<string> assignedPermissionGrantPolicies = authorizationPolicy.DefaultUserRolePermissions?.PermissionGrantPoliciesAssigned
                ?? Enumerable.Empty<string>();

            List<MGTeamsInternalPermissionGrantPolicy> assignedPermissionGrantPoliciesApplicableToGivenScope =
                new List<MGTeamsInternalPermissionGrantPolicy>();

            foreach (MGTeamsInternalPermissionGrantPolicy permissionGrantPolicy in permissionGrantPolicyCollection.Value)
            {
                if (string.Equals(permissionGrantPolicy.ResourceScopeType, identitySpecificScopeType, StringComparison.OrdinalIgnoreCase) &&
                    assignedPermissionGrantPolicies.Contains(permissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId))
                {
                    assignedPermissionGrantPoliciesApplicableToGivenScope.Add(permissionGrantPolicy);
                }
            }

            return assignedPermissionGrantPoliciesApplicableToGivenScope;
        }

        /// <summary>
        /// Get the projected value of IsGroupConsentEnabled.
        /// </summary>
        /// <param name="tenantConsentSettingCollection">Tenant consent setting collection.</param>
        /// <param name="authorizationPolicy">The authorization policy.</param>
        /// <param name="eventListener">The event listener.</param>
        /// <returns>Project value of IsGroupConsentEnabled.</returns>
        private (string isGroupConsentSettingEnabled, string groupConsentConstrainedToGroupId) GetProjectedGroupConsentSettings(
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
                    return (isGroupConsentSettingEnabled: true.ToString(), groupConsentConstrainedToGroupId: null);
                }

                return (isGroupConsentSettingEnabled: false.ToString(), groupConsentConstrainedToGroupId: null);
            }

            MGTeamsInternalTenantConsentSettingValue isGroupConsentEnabledSettingValue = groupConsentSettings.Values?.SingleOrDefault(
                v => string.Equals(v.Name, RscConfigurationSynthesizer.EnableGroupSpecificConsentKey, StringComparison.OrdinalIgnoreCase));

            MGTeamsInternalTenantConsentSettingValue groupConsentConstrainedToGroupId = groupConsentSettings.Values?.SingleOrDefault(
                v => string.Equals(v.Name, RscConfigurationSynthesizer.ConstrainGroupSpecificConsentToMembersOfGroupIdKey, StringComparison.OrdinalIgnoreCase));

            return
                (isGroupConsentSettingEnabled: isGroupConsentEnabledSettingValue?.Value,
                 groupConsentConstrainedToGroupId: groupConsentConstrainedToGroupId?.Value);
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
