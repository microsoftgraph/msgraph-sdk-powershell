---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedapproval
schema: 2.0.0
---

# New-MgPrivilegedApproval

## SYNOPSIS
Add new entity to privilegedApproval

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrivilegedApproval [-AdditionalProperties <Hashtable>] [-ApprovalDuration <TimeSpan>]
 [-ApprovalState <String>] [-ApprovalType <String>] [-ApproverReason <String>] [-EndDateTime <DateTime>]
 [-Id <String>] [-Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>] [-RequestorReason <String>]
 [-RoleId <String>] [-RoleInfo <IMicrosoftGraphPrivilegedRole>] [-StartDateTime <DateTime>] [-UserId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgPrivilegedApproval -BodyParameter <IMicrosoftGraphPrivilegedApproval> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to privilegedApproval

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
privilegedApproval
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EndDateTime
.

```yaml
Type: System.DateTime
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
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Request
privilegedRoleAssignmentRequest
To construct, see NOTES section for REQUEST properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignmentRequest
Parameter Sets: CreateExpanded
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
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDateTime
.

```yaml
Type: System.DateTime
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
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrivilegedApproval>: privilegedApproval
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ApprovalDuration <TimeSpan?>]`: 
  - `[ApprovalState <String>]`: approvalState
  - `[ApprovalType <String>]`: 
  - `[ApproverReason <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>]`: privilegedRoleAssignmentRequest
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AssignmentState <String>]`: 
    - `[Duration <String>]`: 
    - `[Reason <String>]`: 
    - `[RequestedDateTime <DateTime?>]`: 
    - `[RoleId <String>]`: 
    - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[ExpirationDateTime <DateTime?>]`: 
        - `[IsElevated <Boolean?>]`: 
        - `[ResultMessage <String>]`: 
        - `[RoleId <String>]`: 
        - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
        - `[UserId <String>]`: 
      - `[Name <String>]`: 
      - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[ApprovalOnElevation <Boolean?>]`: 
        - `[ApproverIds <String[]>]`: 
        - `[ElevationDuration <TimeSpan?>]`: 
        - `[IsMfaOnElevationConfigurable <Boolean?>]`: 
        - `[LastGlobalAdmin <Boolean?>]`: 
        - `[MaxElavationDuration <TimeSpan?>]`: 
        - `[MfaOnElevation <Boolean?>]`: 
        - `[MinElevationDuration <TimeSpan?>]`: 
        - `[NotificationToUserOnElevation <Boolean?>]`: 
        - `[TicketingInfoOnElevation <Boolean?>]`: 
      - `[Summary <IMicrosoftGraphPrivilegedRoleSummary>]`: privilegedRoleSummary
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[ElevatedCount <Int32?>]`: 
        - `[ManagedCount <Int32?>]`: 
        - `[MfaEnabled <Boolean?>]`: 
        - `[Status <String>]`: roleSummaryStatus
        - `[UsersCount <Int32?>]`: 
    - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Duration <TimeSpan?>]`: 
      - `[EndDateTime <DateTime?>]`: 
      - `[StartDateTime <DateTime?>]`: 
      - `[Type <String>]`: 
    - `[Status <String>]`: 
    - `[TicketNumber <String>]`: 
    - `[TicketSystem <String>]`: 
    - `[Type <String>]`: 
    - `[UserId <String>]`: 
  - `[RequestorReason <String>]`: 
  - `[RoleId <String>]`: 
  - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
  - `[StartDateTime <DateTime?>]`: 
  - `[UserId <String>]`: 

REQUEST <IMicrosoftGraphPrivilegedRoleAssignmentRequest>: privilegedRoleAssignmentRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AssignmentState <String>]`: 
  - `[Duration <String>]`: 
  - `[Reason <String>]`: 
  - `[RequestedDateTime <DateTime?>]`: 
  - `[RoleId <String>]`: 
  - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[IsElevated <Boolean?>]`: 
      - `[ResultMessage <String>]`: 
      - `[RoleId <String>]`: 
      - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
      - `[UserId <String>]`: 
    - `[Name <String>]`: 
    - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ApprovalOnElevation <Boolean?>]`: 
      - `[ApproverIds <String[]>]`: 
      - `[ElevationDuration <TimeSpan?>]`: 
      - `[IsMfaOnElevationConfigurable <Boolean?>]`: 
      - `[LastGlobalAdmin <Boolean?>]`: 
      - `[MaxElavationDuration <TimeSpan?>]`: 
      - `[MfaOnElevation <Boolean?>]`: 
      - `[MinElevationDuration <TimeSpan?>]`: 
      - `[NotificationToUserOnElevation <Boolean?>]`: 
      - `[TicketingInfoOnElevation <Boolean?>]`: 
    - `[Summary <IMicrosoftGraphPrivilegedRoleSummary>]`: privilegedRoleSummary
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[ElevatedCount <Int32?>]`: 
      - `[ManagedCount <Int32?>]`: 
      - `[MfaEnabled <Boolean?>]`: 
      - `[Status <String>]`: roleSummaryStatus
      - `[UsersCount <Int32?>]`: 
  - `[Schedule <IMicrosoftGraphGovernanceSchedule>]`: governanceSchedule
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Duration <TimeSpan?>]`: 
    - `[EndDateTime <DateTime?>]`: 
    - `[StartDateTime <DateTime?>]`: 
    - `[Type <String>]`: 
  - `[Status <String>]`: 
  - `[TicketNumber <String>]`: 
  - `[TicketSystem <String>]`: 
  - `[Type <String>]`: 
  - `[UserId <String>]`: 

ROLEINFO <IMicrosoftGraphPrivilegedRole>: privilegedRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsElevated <Boolean?>]`: 
    - `[ResultMessage <String>]`: 
    - `[RoleId <String>]`: 
    - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[UserId <String>]`: 
  - `[Name <String>]`: 
  - `[Settings <IMicrosoftGraphPrivilegedRoleSettings>]`: privilegedRoleSettings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ApprovalOnElevation <Boolean?>]`: 
    - `[ApproverIds <String[]>]`: 
    - `[ElevationDuration <TimeSpan?>]`: 
    - `[IsMfaOnElevationConfigurable <Boolean?>]`: 
    - `[LastGlobalAdmin <Boolean?>]`: 
    - `[MaxElavationDuration <TimeSpan?>]`: 
    - `[MfaOnElevation <Boolean?>]`: 
    - `[MinElevationDuration <TimeSpan?>]`: 
    - `[NotificationToUserOnElevation <Boolean?>]`: 
    - `[TicketingInfoOnElevation <Boolean?>]`: 
  - `[Summary <IMicrosoftGraphPrivilegedRoleSummary>]`: privilegedRoleSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[ElevatedCount <Int32?>]`: 
    - `[ManagedCount <Int32?>]`: 
    - `[MfaEnabled <Boolean?>]`: 
    - `[Status <String>]`: roleSummaryStatus
    - `[UsersCount <Int32?>]`: 

## RELATED LINKS

