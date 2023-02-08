namespace Microsoft.Graph.Beta.PowerShell.TeamsInternal
{
    using Microsoft.Graph.Beta.PowerShell.Models;
    using Microsoft.Graph.Beta.PowerShell.Models.TeamsInternal;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Validator for Teams App Preapproval objects.
    /// </summary>
    internal class TeamsAppPreApprovalValidator
    {
        private IDictionary<string, MGTeamsInternalSensitivityLabel> sensitivityLabelDictionary;

        internal TeamsAppPreApprovalValidator(MGTeamsInternalSensitivityLabelCollection mGTeamsInternalSensitivityLabelCollection)
        {
            this.sensitivityLabelDictionary = (mGTeamsInternalSensitivityLabelCollection?.Value ?? Enumerable.Empty<MGTeamsInternalSensitivityLabel>()).ToDictionary(s => s.Id, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Validate the given Teams App Preapproval object.
        /// </summary>
        /// <param name="microsoftGraphTeamsAppPreApproval">The teams app preapproval object.</param>
        internal void Validate(IMicrosoftGraphTeamsAppPreApproval microsoftGraphTeamsAppPreApproval)
        {
            if (string.IsNullOrWhiteSpace(microsoftGraphTeamsAppPreApproval.Id))
            {
                throw new MGTeamsInternalException(
                    MGTeamsInternalErrorType.RequiredPropertyNotFound,
                    $"'Id' is empty.");
            }

            this.ValidateConditionsForTeamsAppPreApproval(
                microsoftGraphTeamsAppPreApproval.TeamsAppId,
                microsoftGraphTeamsAppPreApproval.ResourceSpecificApplicationPermissionsAllowedForChats,
                microsoftGraphTeamsAppPreApproval.TeamLevelSensitivityLabelCondition,
                microsoftGraphTeamsAppPreApproval.SpecificSensitivityLabelIdsApplicableToTeams,
                microsoftGraphTeamsAppPreApproval.ResourceSpecificApplicationPermissionsAllowedForTeams);
        }

        /// <summary>
        /// Validate that the given conditions are valid for a teams app preapproval object.
        /// </summary>
        /// <param name="teamsAppId">The teams app id.</param>
        /// <param name="resourceSpecificApplicationPermissionsAllowedForChats">RSC permissions allowed for chats.</param>
        /// <param name="teamLevelSensitivityLabelCondition">Team level sensitivity label selection mode.</param>
        /// <param name="specificSensitivityLabelIdsApplicableToTeams">Specific sensitivity label ids applicable to teams.</param>
        /// <param name="resourceSpecificApplicationPermissionsAllowedForTeams">RSC permissions allowed for teams.</param>
        /// <returns>Task wrapping the preapproval policy.</returns>
        internal void ValidateConditionsForTeamsAppPreApproval(
            string teamsAppId,
            IEnumerable<string> resourceSpecificApplicationPermissionsAllowedForChats,
            MicrosoftGraphSensitivityLabelCondition? teamLevelSensitivityLabelCondition,
            IEnumerable<string> specificSensitivityLabelIdsApplicableToTeams,
            IEnumerable<string> resourceSpecificApplicationPermissionsAllowedForTeams)
        {
            if (string.IsNullOrWhiteSpace(teamsAppId))
            {
                throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"'{nameof(teamsAppId)}' cannot be empty.");
            }

            if (resourceSpecificApplicationPermissionsAllowedForChats == null &&
                resourceSpecificApplicationPermissionsAllowedForTeams == null)
            {
                throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"Both '{nameof(resourceSpecificApplicationPermissionsAllowedForTeams)}' and '{nameof(resourceSpecificApplicationPermissionsAllowedForChats)}' cannot be empty.");
            }

            if (resourceSpecificApplicationPermissionsAllowedForChats != null)
            {
                foreach (string permissionName in resourceSpecificApplicationPermissionsAllowedForChats)
                {
                    if (!permissionName.EndsWith("chat", System.StringComparison.OrdinalIgnoreCase))
                    {
                        throw new MGTeamsInternalException(
                            MGTeamsInternalErrorType.InvalidCmdletInput,
                            $"'{permissionName}' is not a valid permission for chat scope.");
                    }
                }
            }

            if (resourceSpecificApplicationPermissionsAllowedForTeams != null)
            {
                foreach (string permissionName in resourceSpecificApplicationPermissionsAllowedForTeams)
                {
                    if (!permissionName.EndsWith("group", System.StringComparison.OrdinalIgnoreCase))
                    {
                        throw new MGTeamsInternalException(
                            MGTeamsInternalErrorType.InvalidCmdletInput,
                            $"'{permissionName}' is not a valid permission for team scope.");
                    }
                }
            }

            if (specificSensitivityLabelIdsApplicableToTeams != null)
            {
                foreach (string sensitivityLabelId in specificSensitivityLabelIdsApplicableToTeams)
                {
                    if (!this.sensitivityLabelDictionary.TryGetValue(sensitivityLabelId, out _))
                    {
                        throw new MGTeamsInternalException(
                            MGTeamsInternalErrorType.InvalidCmdletInput,
                            $"'Sensitivity Label '{sensitivityLabelId}' was not found.");
                    }
                }
            }

            if (teamLevelSensitivityLabelCondition == null)
            {
                if (resourceSpecificApplicationPermissionsAllowedForTeams != null || specificSensitivityLabelIdsApplicableToTeams != null)
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"'{nameof(resourceSpecificApplicationPermissionsAllowedForTeams)}' and '{nameof(specificSensitivityLabelIdsApplicableToTeams)}' are not allowed without specifying '{nameof(teamLevelSensitivityLabelCondition)}'.");
                }
            }
            else if (teamLevelSensitivityLabelCondition == MicrosoftGraphSensitivityLabelCondition.AnySensitivityLabel)
            {
                if (specificSensitivityLabelIdsApplicableToTeams?.Any() == true)
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"'{nameof(specificSensitivityLabelIdsApplicableToTeams)}' cannot be specified for '{nameof(teamLevelSensitivityLabelCondition)}' : '{teamLevelSensitivityLabelCondition}'.");
                }

                if (resourceSpecificApplicationPermissionsAllowedForTeams?.Any() != true)
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"'{nameof(resourceSpecificApplicationPermissionsAllowedForTeams)}' must be specified for '{nameof(teamLevelSensitivityLabelCondition)}' : '{teamLevelSensitivityLabelCondition}'.");
                }
            }
            else if (teamLevelSensitivityLabelCondition == MicrosoftGraphSensitivityLabelCondition.SpecificSensivityLabel)
            {
                if (specificSensitivityLabelIdsApplicableToTeams?.Any() != true)
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"'{nameof(specificSensitivityLabelIdsApplicableToTeams)}' must be specified for '{nameof(teamLevelSensitivityLabelCondition)}' : '{teamLevelSensitivityLabelCondition}'.");
                }

                if (resourceSpecificApplicationPermissionsAllowedForTeams?.Any() != true)
                {
                    throw new MGTeamsInternalException(
                        MGTeamsInternalErrorType.InvalidCmdletInput,
                        $"'{nameof(resourceSpecificApplicationPermissionsAllowedForTeams)}' must be specified for '{nameof(teamLevelSensitivityLabelCondition)}' : '{teamLevelSensitivityLabelCondition}'.");
                }
            }
        }
    }
}
