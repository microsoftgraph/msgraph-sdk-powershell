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
        internal const string GroupConsentSettingsTemplateId = "dffd5d46-495d-40a9-8e21-954ff55e198a";

        internal const string MicrosoftCreatedPermissionGrantPolicyEnabledForPreapprovedAppsForChats = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-chat";

        internal const string MicrosoftCreatedPermissionGrantPolicyEnabledForAllAppsForChats = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-chat";

        internal const string MicrosoftCreatedPermissionGrantPolicyManagedByMicrosoftForChats = "ManagePermissionGrantsForOwnedResource.microsoft-dynamically-managed-permissions-for-chat";

        internal const string MicrosoftCreatedPermissionGrantPolicyEnabledForPreapprovedAppsForTeams = "ManagePermissionGrantsForOwnedResource.microsoft-pre-approval-apps-for-team";

        internal const string MicrosoftCreatedPermissionGrantPolicyEnabledForAllAppsForTeams = "ManagePermissionGrantsForOwnedResource.microsoft-all-application-permissions-for-team";

        internal const string MicrosoftCreatedPermissionGrantPolicyManagedByMicrosoftForTeams = "ManagePermissionGrantsForOwnedResource.microsoft-dynamically-managed-permissions-for-team";

        /// <summary>
        /// Initializes a new instance of the <see cref="RscConfigurationSynthesizer"/> class.
        /// </summary>
        internal RscConfigurationSynthesizer()
        {
        }

        /// <summary>
        /// Convert the given settings and policy to Chat RSC configuration.
        /// </summary>
        /// <param name="permissionGrantPolicyCollection">The permission grant policy collection.</param>
        /// <param name="teamsAppSettings">Teams app settings.</param>
        /// <param name="authorizationPolicy">Authorization policy.</param>
        /// <param name="eventListener">The event listener.</param>
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
                this.LogVerbose("Chat RSC is enabled in Teams App Settings.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
            }
            else if (assignedPermissionGrantPoliciesApplicableToChatScope.Any())
            {
                int interestingPermissionGrantPolicyCount = assignedPermissionGrantPoliciesApplicableToChatScope.Count();

                if (interestingPermissionGrantPolicyCount > 1)
                {
                    this.LogVerbose("Multiple chat scoped permission grant policies are enabled. Not a supported scenario.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                }
                else if (interestingPermissionGrantPolicyCount == 0)
                {
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.DisabledForAllApps;
                }
                else
                {
                    MGTeamsInternalPermissionGrantPolicy interestingPermissionGrantPolicy =
                        assignedPermissionGrantPoliciesApplicableToChatScope.Single();

                    if (string.Equals(
                        interestingPermissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyEnabledForAllAppsForChats,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        this.LogVerbose("Authorization policy contains permission grant policy for all chat RSC applications.", eventListener);
                        microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
                    }
                    else if (string.Equals(
                        interestingPermissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyEnabledForPreapprovedAppsForChats,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
                    }
                    else if (string.Equals(
                        interestingPermissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyManagedByMicrosoftForChats,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.ManagedByMicrosoft;
                    }
                    else
                    {
                        this.LogVerbose("Unknown chat scoped permission grant policies are enabled. Not a supported scenario.", eventListener);
                        microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                    }
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
        /// <param name="permissionGrantPolicyCollection">Permission grant policy collection.</param>
        /// <param name="authorizationPolicy">Authorization policy.</param>
        /// <returns>Rsc configuration.</returns>
        internal IMicrosoftGraphRscConfiguration ConvertToTeamRscConfiguration(
            MGTeamsInternalPermissionGrantPolicyCollection permissionGrantPolicyCollection,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            Runtime.IEventListener eventListener)
        {
            if (permissionGrantPolicyCollection?.Value == null)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.ResourceNotFound,
                    "Permission grant policies were not found.");
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

            IEnumerable<MGTeamsInternalPermissionGrantPolicy> assignedPermissionGrantPoliciesApplicableToGroupScope =
                this.GetAssignedPermissionGrantPoliciesApplicableToGivenScopeType(
                    permissionGrantPolicyCollection,
                    authorizationPolicy,
                    MicrosoftGraphRscConfigurationScopeType.Team);

            int interestingPermissionGrantPolicyCount = assignedPermissionGrantPoliciesApplicableToGroupScope.Count();

            if (interestingPermissionGrantPolicyCount > 1)
            {
                this.LogVerbose("Multiple group scoped permission grant policies are enabled. Not a supported scenario.", eventListener);
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
            }
            else if (interestingPermissionGrantPolicyCount == 0)
            {
                microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.DisabledForAllApps;
            }
            else
            {
                MGTeamsInternalPermissionGrantPolicy interestingPermissionGrantPolicy = assignedPermissionGrantPoliciesApplicableToGroupScope.Single();
                if (string.Equals(
                        interestingPermissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyEnabledForAllAppsForTeams,
                        StringComparison.OrdinalIgnoreCase))
                {
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForAllApps;
                }
                else if (string.Equals(
                        interestingPermissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyEnabledForPreapprovedAppsForTeams,
                        StringComparison.OrdinalIgnoreCase))
                {
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.EnabledForPreApprovedAppsOnly;
                }
                else if (string.Equals(
                        interestingPermissionGrantPolicy.ManagePermissionGrantsForOwnedResourcePrefixedId,
                        RscConfigurationSynthesizer.MicrosoftCreatedPermissionGrantPolicyManagedByMicrosoftForTeams,
                        StringComparison.OrdinalIgnoreCase))
                {
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.ManagedByMicrosoft;
                }
                else
                {
                    this.LogVerbose("Unknown group scoped permission grant policies are enabled. Not a supported scenario.", eventListener);
                    microsoftGraphRscConfiguration.State = MicrosoftGraphRscConfigurationState.Custom;
                }
            }

            return microsoftGraphRscConfiguration;
        }

        /// <summary>
        /// Get permission grant policies assigned to default user role (all users and apps) which are relevant to the given scope.
        /// </summary>
        /// <param name="permissionGrantPolicyCollection">The permission grant policy collection.</param>
        /// <param name="authorizationPolicy">The authorization policy.</param>
        /// <param name="rscConfigurationScopeType">The rsc config scope type.</param>
        /// <returns>List of policies.</returns>
        internal IEnumerable<MGTeamsInternalPermissionGrantPolicy> GetAssignedPermissionGrantPoliciesApplicableToGivenScopeType(
            MGTeamsInternalPermissionGrantPolicyCollection permissionGrantPolicyCollection,
            MGTeamsInternalAuthorizationPolicy authorizationPolicy,
            MicrosoftGraphRscConfigurationScopeType rscConfigurationScopeType)
        {
            string identitySpecificScopeType;
            switch (rscConfigurationScopeType)
            {
                case MicrosoftGraphRscConfigurationScopeType.Team:
                    identitySpecificScopeType = "team";
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
