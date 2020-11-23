---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedroleassignmentrequest
schema: 2.0.0
---

# Update-MgPrivilegedRoleAssignmentRequest

## SYNOPSIS
Update entity in privilegedRoleAssignmentRequests

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedRoleAssignmentRequest -PrivilegedRoleAssignmentRequestId <String>
 [-AdditionalProperties <Hashtable>] [-AssignmentState <String>] [-Duration <String>] [-Id <String>]
 [-Reason <String>] [-RequestedDateTime <DateTime>] [-RoleId <String>]
 [-RoleInfo <IMicrosoftGraphPrivilegedRole>] [-Schedule <IMicrosoftGraphGovernanceSchedule>] [-Status <String>]
 [-TicketNumber <String>] [-TicketSystem <String>] [-Type <String>] [-UserId <String>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedRoleAssignmentRequest -PrivilegedRoleAssignmentRequestId <String>
 -BodyParameter <IMicrosoftGraphPrivilegedRoleAssignmentRequest> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedRoleAssignmentRequest -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-AssignmentState <String>] [-Duration <String>] [-Id <String>]
 [-Reason <String>] [-RequestedDateTime <DateTime>] [-RoleId <String>]
 [-RoleInfo <IMicrosoftGraphPrivilegedRole>] [-Schedule <IMicrosoftGraphGovernanceSchedule>] [-Status <String>]
 [-TicketNumber <String>] [-TicketSystem <String>] [-Type <String>] [-UserId <String>] [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedRoleAssignmentRequest -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphPrivilegedRoleAssignmentRequest> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update entity in privilegedRoleAssignmentRequests

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignmentState
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
privilegedRoleAssignmentRequest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrivilegedRoleAssignmentRequest
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Duration
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IIdentityGovernanceIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrivilegedRoleAssignmentRequestId
key: id of privilegedRoleAssignmentRequest

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reason
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestedDateTime
.

```yaml
Type: DateTime
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
Type: String
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
To construct, see NOTES section for ROLEINFO properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrivilegedRole
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Schedule
governanceSchedule
To construct, see NOTES section for SCHEDULE properties and create a hash table.

```yaml
Type: IMicrosoftGraphGovernanceSchedule
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TicketNumber
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TicketSystem
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
.

```yaml
Type: String
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
Type: String
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
Type: SwitchParameter
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
Type: SwitchParameter
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignmentRequest
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrivilegedRoleAssignmentRequest\>: privilegedRoleAssignmentRequest
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[AssignmentState \<String\>\]: 
  \[Duration \<String\>\]: 
  \[Reason \<String\>\]: 
  \[RequestedDateTime \<DateTime?\>\]: 
  \[RoleId \<String\>\]: 
  \[RoleInfo \<IMicrosoftGraphPrivilegedRole\>\]: privilegedRole
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Assignments \<IMicrosoftGraphPrivilegedRoleAssignment\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[ExpirationDateTime \<DateTime?\>\]: 
      \[IsElevated \<Boolean?\>\]: 
      \[ResultMessage \<String\>\]: 
      \[RoleId \<String\>\]: 
      \[RoleInfo \<IMicrosoftGraphPrivilegedRole\>\]: privilegedRole
      \[UserId \<String\>\]: 
    \[Name \<String\>\]: 
    \[Settings \<IMicrosoftGraphPrivilegedRoleSettings\>\]: privilegedRoleSettings
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[ApprovalOnElevation \<Boolean?\>\]: 
      \[ApproverIds \<String\[\]\>\]: 
      \[ElevationDuration \<TimeSpan?\>\]: 
      \[IsMfaOnElevationConfigurable \<Boolean?\>\]: 
      \[LastGlobalAdmin \<Boolean?\>\]: 
      \[MaxElavationDuration \<TimeSpan?\>\]: 
      \[MfaOnElevation \<Boolean?\>\]: 
      \[MinElevationDuration \<TimeSpan?\>\]: 
      \[NotificationToUserOnElevation \<Boolean?\>\]: 
      \[TicketingInfoOnElevation \<Boolean?\>\]: 
    \[Summary \<IMicrosoftGraphPrivilegedRoleSummary\>\]: privilegedRoleSummary
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[ElevatedCount \<Int32?\>\]: 
      \[ManagedCount \<Int32?\>\]: 
      \[MfaEnabled \<Boolean?\>\]: 
      \[Status \<String\>\]: roleSummaryStatus
      \[UsersCount \<Int32?\>\]: 
  \[Schedule \<IMicrosoftGraphGovernanceSchedule\>\]: governanceSchedule
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Duration \<TimeSpan?\>\]: 
    \[EndDateTime \<DateTime?\>\]: 
    \[StartDateTime \<DateTime?\>\]: 
    \[Type \<String\>\]: 
  \[Status \<String\>\]: 
  \[TicketNumber \<String\>\]: 
  \[TicketSystem \<String\>\]: 
  \[Type \<String\>\]: 
  \[UserId \<String\>\]: 

INPUTOBJECT \<IIdentityGovernanceIdentity\>: Identity Parameter
  \[AccessPackageAssignmentId \<String\>\]: key: id of accessPackageAssignment
  \[AccessPackageAssignmentPolicyId \<String\>\]: key: id of accessPackageAssignmentPolicy
  \[AccessPackageAssignmentRequestId \<String\>\]: key: id of accessPackageAssignmentRequest
  \[AccessPackageAssignmentResourceRoleId \<String\>\]: key: id of accessPackageAssignmentResourceRole
  \[AccessPackageCatalogId \<String\>\]: key: id of accessPackageCatalog
  \[AccessPackageId \<String\>\]: key: id of accessPackage
  \[AccessPackageResourceId \<String\>\]: key: id of accessPackageResource
  \[AccessPackageResourceRequestId \<String\>\]: key: id of accessPackageResourceRequest
  \[AccessPackageResourceRoleId \<String\>\]: key: id of accessPackageResourceRole
  \[AccessPackageResourceRoleScopeId \<String\>\]: key: id of accessPackageResourceRoleScope
  \[AccessPackageResourceScopeId \<String\>\]: key: id of accessPackageResourceScope
  \[AccessReviewDecisionId \<String\>\]: key: id of accessReviewDecision
  \[AccessReviewId \<String\>\]: key: id of accessReview
  \[AccessReviewId1 \<String\>\]: key: id of accessReview
  \[AccessReviewInstanceId \<String\>\]: key: id of accessReviewInstance
  \[AccessReviewReviewerId \<String\>\]: key: id of accessReviewReviewer
  \[AccessReviewScheduleDefinitionId \<String\>\]: key: id of accessReviewScheduleDefinition
  \[AgreementAcceptanceId \<String\>\]: key: id of agreementAcceptance
  \[AgreementFileLocalizationId \<String\>\]: key: id of agreementFileLocalization
  \[AgreementFileVersionId \<String\>\]: key: id of agreementFileVersion
  \[AgreementId \<String\>\]: key: id of agreement
  \[BusinessFlowTemplateId \<String\>\]: key: id of businessFlowTemplate
  \[ConnectedOrganizationId \<String\>\]: key: id of connectedOrganization
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[GovernanceResourceId \<String\>\]: key: id of governanceResource
  \[GovernanceRoleAssignmentId \<String\>\]: key: id of governanceRoleAssignment
  \[GovernanceRoleAssignmentRequestId \<String\>\]: key: id of governanceRoleAssignmentRequest
  \[GovernanceRoleDefinitionId \<String\>\]: key: id of governanceRoleDefinition
  \[GovernanceRoleSettingId \<String\>\]: key: id of governanceRoleSetting
  \[PrivilegedAccessId \<String\>\]: key: id of privilegedAccess
  \[PrivilegedApprovalId \<String\>\]: key: id of privilegedApproval
  \[PrivilegedOperationEventId \<String\>\]: key: id of privilegedOperationEvent
  \[PrivilegedRoleAssignmentId \<String\>\]: key: id of privilegedRoleAssignment
  \[PrivilegedRoleAssignmentRequestId \<String\>\]: key: id of privilegedRoleAssignmentRequest
  \[PrivilegedRoleId \<String\>\]: key: id of privilegedRole
  \[ProgramControlId \<String\>\]: key: id of programControl
  \[ProgramControlTypeId \<String\>\]: key: id of programControlType
  \[ProgramId \<String\>\]: key: id of program
  \[UserId \<String\>\]: key: id of user

ROLEINFO \<IMicrosoftGraphPrivilegedRole\>: privilegedRole
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphPrivilegedRoleAssignment\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[ExpirationDateTime \<DateTime?\>\]: 
    \[IsElevated \<Boolean?\>\]: 
    \[ResultMessage \<String\>\]: 
    \[RoleId \<String\>\]: 
    \[RoleInfo \<IMicrosoftGraphPrivilegedRole\>\]: privilegedRole
    \[UserId \<String\>\]: 
  \[Name \<String\>\]: 
  \[Settings \<IMicrosoftGraphPrivilegedRoleSettings\>\]: privilegedRoleSettings
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[ApprovalOnElevation \<Boolean?\>\]: 
    \[ApproverIds \<String\[\]\>\]: 
    \[ElevationDuration \<TimeSpan?\>\]: 
    \[IsMfaOnElevationConfigurable \<Boolean?\>\]: 
    \[LastGlobalAdmin \<Boolean?\>\]: 
    \[MaxElavationDuration \<TimeSpan?\>\]: 
    \[MfaOnElevation \<Boolean?\>\]: 
    \[MinElevationDuration \<TimeSpan?\>\]: 
    \[NotificationToUserOnElevation \<Boolean?\>\]: 
    \[TicketingInfoOnElevation \<Boolean?\>\]: 
  \[Summary \<IMicrosoftGraphPrivilegedRoleSummary\>\]: privilegedRoleSummary
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[ElevatedCount \<Int32?\>\]: 
    \[ManagedCount \<Int32?\>\]: 
    \[MfaEnabled \<Boolean?\>\]: 
    \[Status \<String\>\]: roleSummaryStatus
    \[UsersCount \<Int32?\>\]: 

SCHEDULE \<IMicrosoftGraphGovernanceSchedule\>: governanceSchedule
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Duration \<TimeSpan?\>\]: 
  \[EndDateTime \<DateTime?\>\]: 
  \[StartDateTime \<DateTime?\>\]: 
  \[Type \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedroleassignmentrequest](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/update-mgprivilegedroleassignmentrequest)

