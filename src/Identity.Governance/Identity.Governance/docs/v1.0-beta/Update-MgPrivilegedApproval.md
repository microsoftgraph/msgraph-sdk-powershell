---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedapproval
schema: 2.0.0
---

# Update-MgPrivilegedApproval

## SYNOPSIS
Update privilegedapproval

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedApproval -PrivilegedApprovalId <String> [-AdditionalProperties <Hashtable>]
 [-ApprovalDuration <TimeSpan>] [-ApprovalState <String>] [-ApprovalType <String>] [-ApproverReason <String>]
 [-EndDateTime <DateTime>] [-Id <String>] [-Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>]
 [-RequestorReason <String>] [-RoleId <String>] [-RoleInfo <IMicrosoftGraphPrivilegedRole>]
 [-StartDateTime <DateTime>] [-UserId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedApproval -PrivilegedApprovalId <String> -BodyParameter <IMicrosoftGraphPrivilegedApproval>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedApproval -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphPrivilegedApproval> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedApproval -InputObject <IIdentityGovernanceIdentity> [-AdditionalProperties <Hashtable>]
 [-ApprovalDuration <TimeSpan>] [-ApprovalState <String>] [-ApprovalType <String>] [-ApproverReason <String>]
 [-EndDateTime <DateTime>] [-Id <String>] [-Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>]
 [-RequestorReason <String>] [-RoleId <String>] [-RoleInfo <IMicrosoftGraphPrivilegedRole>]
 [-StartDateTime <DateTime>] [-UserId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update privilegedapproval

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

### -ApprovalDuration
.

```yaml
Type: System.TimeSpan
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApprovalState
approvalState

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

### -ApprovalType
.

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

### -ApproverReason
.

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

### -BodyParameter
privilegedApproval
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EndDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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

### -PrivilegedApprovalId
key: id of privilegedApproval

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

### -Request
privilegedRoleAssignmentRequest
To construct, please use Get-Help -Online and see NOTES section for REQUEST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignmentRequest
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestorReason
.

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

### -RoleId
.

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

### -RoleInfo
privilegedRole
To construct, please use Get-Help -Online and see NOTES section for ROLEINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrivilegedApproval>: privilegedApproval
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ApprovalDuration <TimeSpan?>]`: 
  - `[ApprovalState <String>]`: approvalState
  - `[ApprovalType <String>]`: 
  - `[ApproverReason <String>]`: 
  - `[EndDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>]`: privilegedRoleAssignmentRequest
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AssignmentState <String>]`: The state of the assignment. The value can be Eligible for eligible assignment Active - if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.
    - `[Duration <String>]`: The duration of a role assignment.
    - `[Reason <String>]`: The reason for the role assignment.
    - `[RequestedDateTime <DateTime?>]`: Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[RoleId <String>]`: The id of the role.
    - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: The assignments for this role. Read-only. Nullable.
        - `[Id <String>]`: 
        - `[ExpirationDateTime <DateTime?>]`: The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
        - `[IsElevated <Boolean?>]`: true if the role assignment is activated. false if the role assignment is deactivated.
        - `[ResultMessage <String>]`: Result message set by the service.
        - `[RoleId <String>]`: Role identifier. In GUID string format.
        - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
        - `[UserId <String>]`: User identifier. In GUID string format.
      - `[Name <String>]`: Role name.
      - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
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
        - `[Id <String>]`: 
        - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
        - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
        - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
        - `[Status <String>]`: roleSummaryStatus
        - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.
    - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Duration <TimeSpan?>]`: The duration of a role assignment. It is in format of a TimeSpan.
      - `[EndDateTime <DateTime?>]`: The end time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Note: if the value is null, it indicates a permanent assignment.
      - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Type <String>]`: The role assignment schedule type. Only Once is supported for now.
    - `[Status <String>]`: Read-only.The status of the role assignment request. The value can be NotStarted,Completed,RequestedApproval,Scheduled,Approved,ApprovalDenied,ApprovalAborted,Cancelling,Cancelled,Revoked,RequestExpired.
    - `[TicketNumber <String>]`: The ticketNumber for the role assignment.
    - `[TicketSystem <String>]`: The ticketSystem for the role assignment.
    - `[Type <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators add users to roles;UserAdd: Users add role assignments.
    - `[UserId <String>]`: The id of the user.
  - `[RequestorReason <String>]`: 
  - `[RoleId <String>]`: 
  - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
  - `[StartDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[UserId <String>]`: 

INPUTOBJECT <IIdentityGovernanceIdentity>: Identity Parameter
  - `[AccessPackageAssignmentId <String>]`: key: id of accessPackageAssignment
  - `[AccessPackageAssignmentPolicyId <String>]`: key: id of accessPackageAssignmentPolicy
  - `[AccessPackageAssignmentRequestId <String>]`: key: id of accessPackageAssignmentRequest
  - `[AccessPackageAssignmentResourceRoleId <String>]`: key: id of accessPackageAssignmentResourceRole
  - `[AccessPackageCatalogId <String>]`: key: id of accessPackageCatalog
  - `[AccessPackageId <String>]`: key: id of accessPackage
  - `[AccessPackageId1 <String>]`: key: id of accessPackage
  - `[AccessPackageId2 <String>]`: Usage: accessPackageId='{accessPackageId}'
  - `[AccessPackageResourceEnvironmentId <String>]`: key: id of accessPackageResourceEnvironment
  - `[AccessPackageResourceId <String>]`: key: id of accessPackageResource
  - `[AccessPackageResourceRequestId <String>]`: key: id of accessPackageResourceRequest
  - `[AccessPackageResourceRoleId <String>]`: key: id of accessPackageResourceRole
  - `[AccessPackageResourceRoleScopeId <String>]`: key: id of accessPackageResourceRoleScope
  - `[AccessPackageResourceScopeId <String>]`: key: id of accessPackageResourceScope
  - `[AccessReviewDecisionId <String>]`: key: id of accessReviewDecision
  - `[AccessReviewHistoryDefinitionId <String>]`: key: id of accessReviewHistoryDefinition
  - `[AccessReviewHistoryInstanceId <String>]`: key: id of accessReviewHistoryInstance
  - `[AccessReviewId <String>]`: key: id of accessReview
  - `[AccessReviewId1 <String>]`: key: id of accessReview
  - `[AccessReviewInstanceDecisionItemId <String>]`: key: id of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceDecisionItemId1 <String>]`: key: id of accessReviewInstanceDecisionItem
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewReviewerId <String>]`: key: id of accessReviewReviewer
  - `[AccessReviewScheduleDefinitionId <String>]`: key: id of accessReviewScheduleDefinition
  - `[AccessReviewStageId <String>]`: key: id of accessReviewStage
  - `[AgreementAcceptanceId <String>]`: key: id of agreementAcceptance
  - `[AgreementFileLocalizationId <String>]`: key: id of agreementFileLocalization
  - `[AgreementFileVersionId <String>]`: key: id of agreementFileVersion
  - `[AgreementId <String>]`: key: id of agreement
  - `[AppConsentRequestId <String>]`: key: id of appConsentRequest
  - `[ApprovalId <String>]`: key: id of approval
  - `[ApprovalStageId <String>]`: key: id of approvalStage
  - `[ApprovalStepId <String>]`: key: id of approvalStep
  - `[BusinessFlowTemplateId <String>]`: key: id of businessFlowTemplate
  - `[ConnectedOrganizationId <String>]`: key: id of connectedOrganization
  - `[CustomAccessPackageWorkflowExtensionId <String>]`: key: id of customAccessPackageWorkflowExtension
  - `[CustomExtensionHandlerId <String>]`: key: id of customExtensionHandler
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[GovernanceInsightId <String>]`: key: id of governanceInsight
  - `[GovernanceResourceId <String>]`: key: id of governanceResource
  - `[GovernanceRoleAssignmentId <String>]`: key: id of governanceRoleAssignment
  - `[GovernanceRoleAssignmentRequestId <String>]`: key: id of governanceRoleAssignmentRequest
  - `[GovernanceRoleDefinitionId <String>]`: key: id of governanceRoleDefinition
  - `[GovernanceRoleSettingId <String>]`: key: id of governanceRoleSetting
  - `[GroupId <String>]`: key: id of group
  - `[IncompatibleAccessPackageId <String>]`: Usage: incompatibleAccessPackageId='{incompatibleAccessPackageId}'
  - `[On <String>]`: Usage: on='{on}'
  - `[PrivilegedAccessId <String>]`: key: id of privilegedAccess
  - `[PrivilegedApprovalId <String>]`: key: id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentId1 <String>]`: key: id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: id of privilegedRole
  - `[ProgramControlId <String>]`: key: id of programControl
  - `[ProgramControlId1 <String>]`: key: id of programControl
  - `[ProgramControlTypeId <String>]`: key: id of programControlType
  - `[ProgramId <String>]`: key: id of program
  - `[UserConsentRequestId <String>]`: key: id of userConsentRequest
  - `[UserId <String>]`: key: id of user

REQUEST <IMicrosoftGraphPrivilegedRoleAssignmentRequest>: privilegedRoleAssignmentRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AssignmentState <String>]`: The state of the assignment. The value can be Eligible for eligible assignment Active - if it is directly assigned Active by administrators, or activated on an eligible assignment by the users.
  - `[Duration <String>]`: The duration of a role assignment.
  - `[Reason <String>]`: The reason for the role assignment.
  - `[RequestedDateTime <DateTime?>]`: Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RoleId <String>]`: The id of the role.
  - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: The assignments for this role. Read-only. Nullable.
      - `[Id <String>]`: 
      - `[ExpirationDateTime <DateTime?>]`: The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
      - `[IsElevated <Boolean?>]`: true if the role assignment is activated. false if the role assignment is deactivated.
      - `[ResultMessage <String>]`: Result message set by the service.
      - `[RoleId <String>]`: Role identifier. In GUID string format.
      - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
      - `[UserId <String>]`: User identifier. In GUID string format.
    - `[Name <String>]`: Role name.
    - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
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
      - `[Id <String>]`: 
      - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
      - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
      - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
      - `[Status <String>]`: roleSummaryStatus
      - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.
  - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Duration <TimeSpan?>]`: The duration of a role assignment. It is in format of a TimeSpan.
    - `[EndDateTime <DateTime?>]`: The end time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Note: if the value is null, it indicates a permanent assignment.
    - `[StartDateTime <DateTime?>]`: The start time of the role assignment. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Type <String>]`: The role assignment schedule type. Only Once is supported for now.
  - `[Status <String>]`: Read-only.The status of the role assignment request. The value can be NotStarted,Completed,RequestedApproval,Scheduled,Approved,ApprovalDenied,ApprovalAborted,Cancelling,Cancelled,Revoked,RequestExpired.
  - `[TicketNumber <String>]`: The ticketNumber for the role assignment.
  - `[TicketSystem <String>]`: The ticketSystem for the role assignment.
  - `[Type <String>]`: Representing the type of the operation on the role assignment. The value can be AdminAdd: Administrators add users to roles;UserAdd: Users add role assignments.
  - `[UserId <String>]`: The id of the user.

ROLEINFO <IMicrosoftGraphPrivilegedRole>: privilegedRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: The assignments for this role. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[ExpirationDateTime <DateTime?>]`: The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
    - `[IsElevated <Boolean?>]`: true if the role assignment is activated. false if the role assignment is deactivated.
    - `[ResultMessage <String>]`: Result message set by the service.
    - `[RoleId <String>]`: Role identifier. In GUID string format.
    - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[UserId <String>]`: User identifier. In GUID string format.
  - `[Name <String>]`: Role name.
  - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
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
    - `[Id <String>]`: 
    - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
    - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
    - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
    - `[Status <String>]`: roleSummaryStatus
    - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.

## RELATED LINKS

