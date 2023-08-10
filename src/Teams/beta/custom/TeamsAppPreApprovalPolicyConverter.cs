namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using Microsoft.Graph.Beta.PowerShell.Models;
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Converts Teams App Preapproval to permission grant policy model and vice versa.
    /// </summary>
    internal class TeamsAppPreApprovalPolicyConverter
    {
        /// <summary>
        /// Collection of RSC permissions.
        /// </summary>
        private IEnumerable<MGTeamsInternalResourceSpecificPermission> rscPermissionCollection;

        /// <summary>
        /// Backing field for RSC permissions name to Id map.
        /// </summary>
        private IDictionary<string, string> rscPermisssionNameToIdMapPrivate = null;

        /// <summary>
        /// Backing field for RSC permission Id to name map.
        /// </summary>
        private IDictionary<string, string> rscPermisssionIdToNameMapPrivate = null;

        /// <summary>
        /// RSC permission name to Id map.
        /// </summary>
        private IDictionary<string, string> RscPermisssionNameToIdMap
        {
            get
            {
                if (this.rscPermisssionNameToIdMapPrivate == null)
                {
                    if (this.rscPermissionCollection != null)
                    {
                        this.rscPermisssionNameToIdMapPrivate = this.rscPermissionCollection.ToDictionary(
                            e => e.Value,
                            e => e.Id,
                            StringComparer.OrdinalIgnoreCase);
                    }
                }

                return this.rscPermisssionNameToIdMapPrivate;
            }
        }

        /// <summary>
        /// RSC permission Id to name map.
        /// </summary>
        private IDictionary<string, string> RscPermisssionIdToNameMap
        {
            get
            {
                if (this.rscPermisssionIdToNameMapPrivate == null)
                {
                    if (this.rscPermissionCollection != null)
                    {
                        this.rscPermisssionIdToNameMapPrivate = this.rscPermissionCollection.ToDictionary(
                            e => e.Id,
                            e => e.Value,
                            StringComparer.OrdinalIgnoreCase);
                    }
                }

                return this.rscPermisssionIdToNameMapPrivate;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAppPreApprovalPolicyConverter"/> class.
        /// </summary>
        /// <param name="rscPermissionCollection">RSC permisssion collection.</param>
        internal TeamsAppPreApprovalPolicyConverter(IEnumerable<MGTeamsInternalResourceSpecificPermission> rscPermissionCollection)
        {
            this.rscPermissionCollection = rscPermissionCollection;
        }

        /// <summary>
        /// Convert the given set of conditions to a permission grant preapproval policy.
        /// </summary>
        /// <param name="resourceSpecificApplicationPermissionsAllowedForChats">RSC permissions allowed for chats.</param>
        /// <param name="teamLevelSensitivityLabelSelectionMode">Team level sensitivity label selection mode.</param>
        /// <param name="specificSensitivityLabelIdsApplicableToTeams">Specific sensitivity label ids applicable to teams.</param>
        /// <param name="resourceSpecificApplicationPermissionsAllowedForTeams">RSC permissions allowed for teams.</param>
        /// <returns>Task wrapping the preapproval policy.</returns>
        internal async Task<MGTeamsInternalPermissionGrantPreApprovalPolicy> ConvertToPermissionGrantPreApprovalPolicy(
            IEnumerable<string> resourceSpecificApplicationPermissionsAllowedForChats,
            MicrosoftGraphSensitivityLabelCondition? teamLevelSensitivityLabelSelectionMode,
            IEnumerable<string> specificSensitivityLabelIdsApplicableToTeams,
            IEnumerable<string> resourceSpecificApplicationPermissionsAllowedForTeams)
        {
            bool createTeamCondition =
                resourceSpecificApplicationPermissionsAllowedForTeams?.Any() == true ||
                teamLevelSensitivityLabelSelectionMode != null ||
                specificSensitivityLabelIdsApplicableToTeams?.Any() == true;

            bool createChatCondition =
                resourceSpecificApplicationPermissionsAllowedForChats != null;

            List<MGTeamsInternalPreapprovalDetail> preApprovalConditions = new List<MGTeamsInternalPreapprovalDetail>();
            if (createChatCondition)
            {
                IEnumerable<string> chatRscPermissionIds =
                    await this.ValidateAndGetRscPermissionIds(resourceSpecificApplicationPermissionsAllowedForChats);

                MGTeamsInternalPreapprovalDetail preapprovalDetail = new MGTeamsInternalPreapprovalDetail(
                    scopeType: "chat",
                    sensitivityLabels: new MGTeamsInternalAllScopeSensitivityLabels(),
                    permissions: new MGTeamsInternalEnumeratedPreApprovedPermissions(chatRscPermissionIds));

                preApprovalConditions.Add(preapprovalDetail);
            }

            if (createTeamCondition)
            {
                IEnumerable<string> teamRscPermissionIds =
                    await this.ValidateAndGetRscPermissionIds(resourceSpecificApplicationPermissionsAllowedForTeams);

                MGTeamsInternalPreapprovalDetail preapprovalDetail = new MGTeamsInternalPreapprovalDetail(
                    scopeType: "group",
                    sensitivityLabels: this.GetTeamSensitivityLabelsForPreApprovalDetail(
                        teamLevelSensitivityLabelSelectionMode,
                        specificSensitivityLabelIdsApplicableToTeams),
                    permissions: new MGTeamsInternalEnumeratedPreApprovedPermissions(teamRscPermissionIds));

                preApprovalConditions.Add(preapprovalDetail);
            }

            MGTeamsInternalPermissionGrantPreApprovalPolicy preApprovalPolicy =
                new MGTeamsInternalPermissionGrantPreApprovalPolicy(conditions: preApprovalConditions);

            return preApprovalPolicy;
        }

        /// <summary>
        /// Convert the given permission grant policy to a Teams App Preapproval object.
        /// </summary>
        /// <param name="teamsAppId">The teams app Id.</param>
        /// <param name="permissionGrantPreApprovalPolicy">The preapproval policy.</param>
        /// <returns>Teams App Preapproval object</returns>
        internal async Task<IMicrosoftGraphTeamsAppPreApproval> ConvertToTeamsAppPreApproval(
            string teamsAppId,
            MGTeamsInternalPermissionGrantPreApprovalPolicy permissionGrantPreApprovalPolicy)
        {
            MicrosoftGraphTeamsAppPreApproval teamsAppPreApproval = new MicrosoftGraphTeamsAppPreApproval();
            teamsAppPreApproval.Id = $"TeamsAppPreApproval_{teamsAppId}_{permissionGrantPreApprovalPolicy.Id}";

            teamsAppPreApproval.TeamsAppId = teamsAppId;

            if (permissionGrantPreApprovalPolicy.Conditions.Count() > 2)
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.UnsupportedScenario,
                    $"Unsupported scenario. Preapproval policy '{permissionGrantPreApprovalPolicy.Id}' has more than 2 conditions.");
            }

            MGTeamsInternalPreapprovalDetail groupCondition =
                permissionGrantPreApprovalPolicy.Conditions.FirstOrDefault(c => string.Equals(c.ScopeType, "group"));

            MGTeamsInternalPreapprovalDetail chatCondition =
                permissionGrantPreApprovalPolicy.Conditions.FirstOrDefault(c => string.Equals(c.ScopeType, "chat"));

            if (permissionGrantPreApprovalPolicy.Conditions.Any(c => c != groupCondition && c != chatCondition))
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.UnsupportedScenario,
                    $"Unsupported scenario. Preapproval policy '{permissionGrantPreApprovalPolicy.Id}' has unsupported conditions.");
            }

            if (groupCondition != null)
            {
                if (string.Equals(groupCondition.SensitivityLabels.OdataType, "#microsoft.graph.allScopeSensitivityLabels", System.StringComparison.OrdinalIgnoreCase))
                {
                    teamsAppPreApproval.TeamLevelSensitivityLabelCondition = MicrosoftGraphSensitivityLabelCondition.AnySensitivityLabel;
                }
                else if (string.Equals(groupCondition.SensitivityLabels.OdataType, "#microsoft.graph.enumeratedScopeSensitivityLabels", System.StringComparison.OrdinalIgnoreCase))
                {
                    teamsAppPreApproval.TeamLevelSensitivityLabelCondition = MicrosoftGraphSensitivityLabelCondition.SpecificSensivityLabel;
                    MGTeamsInternalEnumeratedScopeSensitivityLabels mGTeamsInternalEnumeratedScopeSensitivityLabels =
                        groupCondition.SensitivityLabels as MGTeamsInternalEnumeratedScopeSensitivityLabels;
                    teamsAppPreApproval.SpecificSensitivityLabelIdsApplicableToTeams = mGTeamsInternalEnumeratedScopeSensitivityLabels.SensitivityLabels.ToArray();
                }
                else
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.UnsupportedScenario,
                        $"Unsupported team scope sensitivity label type '{groupCondition.SensitivityLabels.OdataType}' in preapproval policy '{permissionGrantPreApprovalPolicy.Id}'.");
                }

                MGTeamsInternalEnumeratedPreApprovedPermissions mGTeamsInternalEnumeratedPreApprovedPermissions =
                    groupCondition.Permissions as MGTeamsInternalEnumeratedPreApprovedPermissions;
                if (mGTeamsInternalEnumeratedPreApprovedPermissions != null)
                {
                    teamsAppPreApproval.ResourceSpecificApplicationPermissionsAllowedForTeams =
                        this.ConvertToPermissionNames(mGTeamsInternalEnumeratedPreApprovedPermissions.PermissionIds).ToArray();
                }
                else
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.UnsupportedScenario,
                        $"Unsupported permission type '{groupCondition.Permissions.OdataType}' in preapproval policy '{permissionGrantPreApprovalPolicy.Id}'.");
                }
            }

            if (chatCondition != null)
            {
                if (!string.Equals(chatCondition.SensitivityLabels.OdataType, "#microsoft.graph.allScopeSensitivityLabels", System.StringComparison.OrdinalIgnoreCase))
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.UnsupportedScenario,
                        $"Unsupported chat scope sensitivity label type '{chatCondition.SensitivityLabels.OdataType}' in preapproval policy '{permissionGrantPreApprovalPolicy.Id}'.");
                }

                MGTeamsInternalEnumeratedPreApprovedPermissions mGTeamsInternalEnumeratedPreApprovedPermissions =
                    chatCondition.Permissions as MGTeamsInternalEnumeratedPreApprovedPermissions;
                if (mGTeamsInternalEnumeratedPreApprovedPermissions != null)
                {
                    teamsAppPreApproval.ResourceSpecificApplicationPermissionsAllowedForChats =
                        this.ConvertToPermissionNames(mGTeamsInternalEnumeratedPreApprovedPermissions.PermissionIds).ToArray();
                }
                else
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.UnsupportedScenario,
                        $"Unsupported permission type '{chatCondition.Permissions.OdataType}' in preapproval policy '{permissionGrantPreApprovalPolicy.Id}'.");
                }
            }

            return teamsAppPreApproval;
        }

        /// <summary>
        /// Convert the given permission Ids to permission names.
        /// </summary>
        /// <param name="permissionIds">The permission Ids.</param>
        /// <returns>Permission names.</returns>
        private IEnumerable<string> ConvertToPermissionNames(IEnumerable<string> permissionIds)
        {
            List<string> rscPermissionNames = new List<string>();

            foreach (string rscPermissionId in permissionIds)
            {
                if (this.RscPermisssionIdToNameMap.TryGetValue(rscPermissionId, out string rscPermissionName))
                {
                    rscPermissionNames.Add(rscPermissionName);
                }
                else
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.ResourceNotFound,
                        $"No resource specific permission was found with Id '{rscPermissionId}'.");
                }
            }

            return rscPermissionNames;
        }

        /// <summary>
        /// Get Scope sensitivity label model for the given label selection mode and ids.
        /// </summary>
        /// <param name="teamLevelSensitivityLabelSelectionMode">The team level label selection mode.</param>
        /// <param name="specificSensitivityLabelIdsApplicableToTeams">The label ids.</param>
        /// <returns>Scope sensitivity labels.</returns>
        private MGTeamsInternalScopeSensitivityLabels GetTeamSensitivityLabelsForPreApprovalDetail(
            MicrosoftGraphSensitivityLabelCondition? teamLevelSensitivityLabelSelectionMode,
            IEnumerable<string> specificSensitivityLabelIdsApplicableToTeams)
        {
            if (teamLevelSensitivityLabelSelectionMode == MicrosoftGraphSensitivityLabelCondition.AnySensitivityLabel)
            {
                return new MGTeamsInternalAllScopeSensitivityLabels();
            }

            if (teamLevelSensitivityLabelSelectionMode == MicrosoftGraphSensitivityLabelCondition.SpecificSensivityLabel)
            {
                return new MGTeamsInternalEnumeratedScopeSensitivityLabels(specificSensitivityLabelIdsApplicableToTeams);
            }

            throw new MGTeamsInternalException(
                MGTeamsInternalErrorType.UnsupportedScenario,
                $"Invalid label selection mode: '{teamLevelSensitivityLabelSelectionMode}'");
        }

        /// <summary>
        /// Validate the given RSC permission name and get corresponding permission Ids.
        /// </summary>
        /// <param name="resourceSpecificApplicationPermissionNames">The permission names.</param>
        /// <returns>Permision Ids.</returns>
        private async System.Threading.Tasks.Task<IEnumerable<string>> ValidateAndGetRscPermissionIds(IEnumerable<string> resourceSpecificApplicationPermissionNames)
        {
            List<string> rscPermissionIds = new List<string>();

            foreach (string rscPermissionName in resourceSpecificApplicationPermissionNames)
            {
                if (this.RscPermisssionNameToIdMap.TryGetValue(rscPermissionName, out string rscPermissionId))
                {
                    rscPermissionIds.Add(rscPermissionId);
                }
                else
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.ResourceNotFound,
                        $"No resource specific permission was found with name '{rscPermissionName}'.");
                }
            }

            return rscPermissionIds;
        }
    }
}
