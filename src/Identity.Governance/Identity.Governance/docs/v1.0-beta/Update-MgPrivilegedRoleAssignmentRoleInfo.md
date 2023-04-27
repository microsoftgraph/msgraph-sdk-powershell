---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedroleassignmentroleinfo
schema: 2.0.0
---

# Update-MgPrivilegedRoleAssignmentRoleInfo

## SYNOPSIS
Update the navigation property roleInfo in privilegedRoleAssignments

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedRoleAssignmentRoleInfo -PrivilegedRoleAssignmentId <String>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-Id <String>]
 [-Name <String>] [-Settings <IMicrosoftGraphPrivilegedRoleSettings>]
 [-Summary <IMicrosoftGraphPrivilegedRoleSummary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedRoleAssignmentRoleInfo -PrivilegedRoleAssignmentId <String>
 -BodyParameter <IMicrosoftGraphPrivilegedRole> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedRoleAssignmentRoleInfo -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphPrivilegedRole> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedRoleAssignmentRoleInfo -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-Id <String>]
 [-Name <String>] [-Settings <IMicrosoftGraphPrivilegedRoleSettings>]
 [-Summary <IMicrosoftGraphPrivilegedRoleSummary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property roleInfo in privilegedRoleAssignments

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
The assignments for this role.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
privilegedRole
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
Role name.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivilegedRoleAssignmentId
The unique identifier of privilegedRoleAssignment

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Settings
privilegedRoleSettings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleSettings
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Summary
privilegedRoleSummary
To construct, please use Get-Help -Online and see NOTES section for SUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleSummary
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphPrivilegedRoleAssignment[]>: The assignments for this role. Read-only. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
  - `[IsElevated <Boolean?>]`: true if the role assignment is activated. false if the role assignment is deactivated.
  - `[ResultMessage <String>]`: Result message set by the service.
  - `[RoleId <String>]`: Role identifier. In GUID string format.
  - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: The assignments for this role. Read-only. Nullable.
    - `[Name <String>]`: Role name.
    - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[ApprovalOnElevation <Boolean?>]`: true if the approval is required when activate the role. false if the approval is not required when activate the role.
      - `[ApproverIds <String[]>]`: List of Approval ids, if approval is required for activation.
      - `[ElevationDuration <TimeSpan?>]`: The duration when the role is activated.
      - `[IsMfaOnElevationConfigurable <Boolean?>]`: true if mfaOnElevation is configurable. false if mfaOnElevation is not configurable.
      - `[LastGlobalAdmin <Boolean?>]`: Internal used only.
      - `[MaxElavationDuration <TimeSpan?>]`: Maximal duration for the activated role.
      - `[MfaOnElevation <Boolean?>]`: true if MFA is required to activate the role. false if MFA is not required to activate the role.
      - `[MinElevationDuration <TimeSpan?>]`: Minimal duration for the activated role.
      - `[NotificationToUserOnElevation <Boolean?>]`: true if send notification to the end user when the role is activated. false if do not send notification when the role is activated.
      - `[TicketingInfoOnElevation <Boolean?>]`: true if the ticketing information is required when activate the role. false if the ticketing information is not required when activate the role.
    - `[Summary <IMicrosoftGraphPrivilegedRoleSummary>]`: privilegedRoleSummary
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
      - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
      - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
      - `[Status <String>]`: roleSummaryStatus
      - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.
  - `[UserId <String>]`: User identifier. In GUID string format.

BODYPARAMETER <IMicrosoftGraphPrivilegedRole>: privilegedRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: The assignments for this role. Read-only. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ExpirationDateTime <DateTime?>]`: The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
    - `[IsElevated <Boolean?>]`: true if the role assignment is activated. false if the role assignment is deactivated.
    - `[ResultMessage <String>]`: Result message set by the service.
    - `[RoleId <String>]`: Role identifier. In GUID string format.
    - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[UserId <String>]`: User identifier. In GUID string format.
  - `[Name <String>]`: Role name.
  - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ApprovalOnElevation <Boolean?>]`: true if the approval is required when activate the role. false if the approval is not required when activate the role.
    - `[ApproverIds <String[]>]`: List of Approval ids, if approval is required for activation.
    - `[ElevationDuration <TimeSpan?>]`: The duration when the role is activated.
    - `[IsMfaOnElevationConfigurable <Boolean?>]`: true if mfaOnElevation is configurable. false if mfaOnElevation is not configurable.
    - `[LastGlobalAdmin <Boolean?>]`: Internal used only.
    - `[MaxElavationDuration <TimeSpan?>]`: Maximal duration for the activated role.
    - `[MfaOnElevation <Boolean?>]`: true if MFA is required to activate the role. false if MFA is not required to activate the role.
    - `[MinElevationDuration <TimeSpan?>]`: Minimal duration for the activated role.
    - `[NotificationToUserOnElevation <Boolean?>]`: true if send notification to the end user when the role is activated. false if do not send notification when the role is activated.
    - `[TicketingInfoOnElevation <Boolean?>]`: true if the ticketing information is required when activate the role. false if the ticketing information is not required when activate the role.
  - `[Summary <IMicrosoftGraphPrivilegedRoleSummary>]`: privilegedRoleSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
    - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
    - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
    - `[Status <String>]`: roleSummaryStatus
    - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.

INPUTOBJECT <IIdentityGovernanceIdentity>: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: The unique identifier of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: The unique identifier of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: The unique identifier of accessPackageAssignmentRequest
  - `[AccessPackageAssignmentResourceRoleId <String>]`: The unique identifier of accessPackageAssignmentResourceRole
  - `[AccessPackageCatalogId <String>]`: The unique identifier of accessPackageCatalog
  - `[AccessPackageId <String>]`: The unique identifier of accessPackage
  - `[AccessPackageId1 <String>]`: The unique identifier of accessPackage
  - `[AccessPackageId2 <String>]`: Usage: accessPackageId='{accessPackageId}'
  - `[AccessPackageQuestionId <String>]`: The unique identifier of accessPackageQuestion
  - `[AccessPackageResourceEnvironmentId <String>]`: The unique identifier of accessPackageResourceEnvironment
  - `[AccessPackageResourceId <String>]`: The unique identifier of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: The unique identifier of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: The unique identifier of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: The unique identifier of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: The unique identifier of accessPackageResourceScope
  - `[AccessPackageSubjectId <String>]`: The unique identifier of accessPackageSubject
  - `[AccessReviewDecisionId <String>]`: The unique identifier of accessReviewDecision
  - `[AccessReviewHistoryDefinitionId <String>]`: The unique identifier of accessReviewHistoryDefinition
  - `[AccessReviewHistoryInstanceId <String>]`: The unique identifier of accessReviewHistoryInstance
  - `[AccessReviewId <String>]`: The unique identifier of accessReview
  - `[AccessReviewId1 <String>]`: The unique identifier of accessReview
  - `[AccessReviewInstanceDecisionItemId <String>]`: The unique identifier of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceDecisionItemId1 <String>]`: The unique identifier of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceId <String>]`: The unique identifier of accessReviewInstance
  - `[AccessReviewReviewerId <String>]`: The unique identifier of accessReviewReviewer
  - `[AccessReviewScheduleDefinitionId <String>]`: The unique identifier of accessReviewScheduleDefinition
  - `[AccessReviewStageId <String>]`: The unique identifier of accessReviewStage
  - `[AgreementAcceptanceId <String>]`: The unique identifier of agreementAcceptance
  - `[AgreementFileLocalizationId <String>]`: The unique identifier of agreementFileLocalization
  - `[AgreementFileVersionId <String>]`: The unique identifier of agreementFileVersion
  - `[AgreementId <String>]`: The unique identifier of agreement
  - `[AppConsentRequestId <String>]`: The unique identifier of appConsentRequest
  - `[ApprovalId <String>]`: The unique identifier of approval
  - `[ApprovalStageId <String>]`: The unique identifier of approvalStage
  - `[ApprovalStepId <String>]`: The unique identifier of approvalStep
  - `[BusinessFlowTemplateId <String>]`: The unique identifier of businessFlowTemplate
  - `[ConnectedOrganizationId <String>]`: The unique identifier of connectedOrganization
  - `[CustomAccessPackageWorkflowExtensionId <String>]`: The unique identifier of customAccessPackageWorkflowExtension
  - `[CustomCalloutExtensionId <String>]`: The unique identifier of customCalloutExtension
  - `[CustomExtensionHandlerId <String>]`: The unique identifier of customExtensionHandler
  - `[CustomExtensionStageSettingId <String>]`: The unique identifier of customExtensionStageSetting
  - `[CustomTaskExtensionId <String>]`: The unique identifier of customTaskExtension
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[EndDateTime <DateTime?>]`: Usage: endDateTime={endDateTime}
  - `[GovernanceInsightId <String>]`: The unique identifier of governanceInsight
  - `[GovernanceResourceId <String>]`: The unique identifier of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: The unique identifier of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: The unique identifier of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: The unique identifier of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: The unique identifier of governanceRoleSetting
  - `[GroupId <String>]`: The unique identifier of group
  - `[IncompatibleAccessPackageId <String>]`: Usage: incompatibleAccessPackageId='{incompatibleAccessPackageId}'
  - `[LongRunningOperationId <String>]`: The unique identifier of longRunningOperation
  - `[On <String>]`: Usage: on='{on}'
  - `[PrivilegedAccessGroupAssignmentScheduleId <String>]`: The unique identifier of privilegedAccessGroupAssignmentSchedule
  - `[PrivilegedAccessGroupAssignmentScheduleInstanceId <String>]`: The unique identifier of privilegedAccessGroupAssignmentScheduleInstance
  - `[PrivilegedAccessGroupAssignmentScheduleRequestId <String>]`: The unique identifier of privilegedAccessGroupAssignmentScheduleRequest
  - `[PrivilegedAccessGroupEligibilityScheduleId <String>]`: The unique identifier of privilegedAccessGroupEligibilitySchedule
  - `[PrivilegedAccessGroupEligibilityScheduleInstanceId <String>]`: The unique identifier of privilegedAccessGroupEligibilityScheduleInstance
  - `[PrivilegedAccessGroupEligibilityScheduleRequestId <String>]`: The unique identifier of privilegedAccessGroupEligibilityScheduleRequest
  - `[PrivilegedAccessId <String>]`: The unique identifier of privilegedAccess
  - `[PrivilegedApprovalId <String>]`: The unique identifier of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: The unique identifier of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: The unique identifier of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentId1 <String>]`: The unique identifier of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: The unique identifier of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: The unique identifier of privilegedRole
  - `[ProgramControlId <String>]`: The unique identifier of programControl
  - `[ProgramControlId1 <String>]`: The unique identifier of programControl
  - `[ProgramControlTypeId <String>]`: The unique identifier of programControlType
  - `[ProgramId <String>]`: The unique identifier of program
  - `[RunId <String>]`: The unique identifier of run
  - `[StartDateTime <DateTime?>]`: Usage: startDateTime={startDateTime}
  - `[TaskDefinitionId <String>]`: The unique identifier of taskDefinition
  - `[TaskId <String>]`: The unique identifier of task
  - `[TaskProcessingResultId <String>]`: The unique identifier of taskProcessingResult
  - `[TaskReportId <String>]`: The unique identifier of taskReport
  - `[UnifiedRoleManagementAlertConfigurationId <String>]`: The unique identifier of unifiedRoleManagementAlertConfiguration
  - `[UnifiedRoleManagementAlertDefinitionId <String>]`: The unique identifier of unifiedRoleManagementAlertDefinition
  - `[UnifiedRoleManagementAlertId <String>]`: The unique identifier of unifiedRoleManagementAlert
  - `[UnifiedRoleManagementAlertIncidentId <String>]`: The unique identifier of unifiedRoleManagementAlertIncident
  - `[UserConsentRequestId <String>]`: The unique identifier of userConsentRequest
  - `[UserId <String>]`: The unique identifier of user
  - `[UserProcessingResultId <String>]`: The unique identifier of userProcessingResult
  - `[WorkflowId <String>]`: The unique identifier of workflow
  - `[WorkflowTemplateId <String>]`: The unique identifier of workflowTemplate
  - `[WorkflowVersionNumber <Int32?>]`: The unique identifier of workflowVersion

SETTINGS <IMicrosoftGraphPrivilegedRoleSettings>: privilegedRoleSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ApprovalOnElevation <Boolean?>]`: true if the approval is required when activate the role. false if the approval is not required when activate the role.
  - `[ApproverIds <String[]>]`: List of Approval ids, if approval is required for activation.
  - `[ElevationDuration <TimeSpan?>]`: The duration when the role is activated.
  - `[IsMfaOnElevationConfigurable <Boolean?>]`: true if mfaOnElevation is configurable. false if mfaOnElevation is not configurable.
  - `[LastGlobalAdmin <Boolean?>]`: Internal used only.
  - `[MaxElavationDuration <TimeSpan?>]`: Maximal duration for the activated role.
  - `[MfaOnElevation <Boolean?>]`: true if MFA is required to activate the role. false if MFA is not required to activate the role.
  - `[MinElevationDuration <TimeSpan?>]`: Minimal duration for the activated role.
  - `[NotificationToUserOnElevation <Boolean?>]`: true if send notification to the end user when the role is activated. false if do not send notification when the role is activated.
  - `[TicketingInfoOnElevation <Boolean?>]`: true if the ticketing information is required when activate the role. false if the ticketing information is not required when activate the role.

SUMMARY <IMicrosoftGraphPrivilegedRoleSummary>: privilegedRoleSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
  - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
  - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
  - `[Status <String>]`: roleSummaryStatus
  - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.

## RELATED LINKS

