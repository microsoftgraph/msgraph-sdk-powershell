---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedroleassignmentrequest
schema: 2.0.0
---

# New-MgPrivilegedRoleAssignmentRequest

## SYNOPSIS
Add new entity to privilegedRoleAssignmentRequests

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrivilegedRoleAssignmentRequest [-AdditionalProperties <Hashtable>] [-AssignmentState <String>]
 [-Duration <String>] [-Id <String>] [-Reason <String>] [-RequestedDateTime <DateTime>] [-RoleId <String>]
 [-RoleInfo <IMicrosoftGraphPrivilegedRole>] [-Schedule <IMicrosoftGraphGovernanceSchedule>] [-Status <String>]
 [-TicketNumber <String>] [-TicketSystem <String>] [-Type <String>] [-UserId <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgPrivilegedRoleAssignmentRequest -BodyParameter <IMicrosoftGraphPrivilegedRoleAssignmentRequest> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to privilegedRoleAssignmentRequests

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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reason
.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignmentRequest
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignmentRequest
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

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedroleassignmentrequest](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedroleassignmentrequest)

