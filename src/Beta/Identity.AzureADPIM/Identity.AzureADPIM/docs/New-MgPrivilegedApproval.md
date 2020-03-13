---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/new-mgprivilegedapproval
schema: 2.0.0
---

# New-MgPrivilegedApproval

## SYNOPSIS
Add new entity to privilegedApproval

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrivilegedApproval [-ApprovalDuration <TimeSpan>] [-ApprovalState <String>] [-ApprovalType <String>]
 [-ApproverReason <String>] [-EndDateTime <DateTime>] [-Id <String>]
 [-Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>] [-RequestorReason <String>] [-RoleId <String>]
 [-RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-RoleInfoId <String>]
 [-RoleInfoName <String>] [-SettingApprovalOnElevation] [-SettingApproverIds <String[]>]
 [-SettingElevationDuration <TimeSpan>] [-SettingId <String>] [-SettingIsMfaOnElevationConfigurable]
 [-SettingLastGlobalAdmin] [-SettingMaxElavationDuration <TimeSpan>] [-SettingMfaOnElevation]
 [-SettingMinElevationDuration <TimeSpan>] [-SettingNotificationToUserOnElevation]
 [-SettingTicketingInfoOnElevation] [-StartDateTime <DateTime>] [-SummaryElevatedCount <Int32>]
 [-SummaryId <String>] [-SummaryManagedCount <Int32>] [-SummaryMfaEnabled] [-SummaryStatus <String>]
 [-SummaryUsersCount <Int32>] [-UserId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -RoleInfoAssignments
.
To construct, see NOTES section for ROLEINFOASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RoleInfoId
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
Dynamic: False
```

### -RoleInfoName
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
Dynamic: False
```

### -SettingApprovalOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingApproverIds
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingElevationDuration
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
Dynamic: False
```

### -SettingId
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
Dynamic: False
```

### -SettingIsMfaOnElevationConfigurable
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingLastGlobalAdmin
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingMaxElavationDuration
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
Dynamic: False
```

### -SettingMfaOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingMinElevationDuration
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
Dynamic: False
```

### -SettingNotificationToUserOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SettingTicketingInfoOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -SummaryElevatedCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SummaryId
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
Dynamic: False
```

### -SummaryManagedCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SummaryMfaEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SummaryStatus
roleSummaryStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SummaryUsersCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphPrivilegedApproval>: privilegedApproval
  - `[Id <String>]`: Read-only.
  - `[ApprovalDuration <TimeSpan?>]`: 
  - `[ApprovalState <String>]`: approvalState
  - `[ApprovalType <String>]`: 
  - `[ApproverReason <String>]`: 
  - `[EndDateTime <DateTime?>]`: 
  - `[Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>]`: privilegedRoleAssignmentRequest
    - `[Id <String>]`: Read-only.
    - `[AssignmentState <String>]`: 
    - `[Duration <String>]`: 
    - `[Reason <String>]`: 
    - `[RequestedDateTime <DateTime?>]`: 
    - `[RoleId <String>]`: 
    - `[RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[ExpirationDateTime <DateTime?>]`: 
      - `[IsElevated <Boolean?>]`: 
      - `[ResultMessage <String>]`: 
      - `[RoleId <String>]`: 
      - `[RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
      - `[RoleInfoId <String>]`: Read-only.
      - `[RoleInfoName <String>]`: 
      - `[SettingApprovalOnElevation <Boolean?>]`: 
      - `[SettingApproverIds <String[]>]`: 
      - `[SettingElevationDuration <TimeSpan?>]`: 
      - `[SettingId <String>]`: Read-only.
      - `[SettingIsMfaOnElevationConfigurable <Boolean?>]`: 
      - `[SettingLastGlobalAdmin <Boolean?>]`: 
      - `[SettingMaxElavationDuration <TimeSpan?>]`: 
      - `[SettingMfaOnElevation <Boolean?>]`: 
      - `[SettingMinElevationDuration <TimeSpan?>]`: 
      - `[SettingNotificationToUserOnElevation <Boolean?>]`: 
      - `[SettingTicketingInfoOnElevation <Boolean?>]`: 
      - `[SummaryElevatedCount <Int32?>]`: 
      - `[SummaryId <String>]`: Read-only.
      - `[SummaryManagedCount <Int32?>]`: 
      - `[SummaryMfaEnabled <Boolean?>]`: 
      - `[SummaryStatus <String>]`: roleSummaryStatus
      - `[SummaryUsersCount <Int32?>]`: 
      - `[UserId <String>]`: 
    - `[RoleInfoId <String>]`: Read-only.
    - `[RoleInfoName <String>]`: 
    - `[ScheduleDuration <TimeSpan?>]`: 
    - `[ScheduleEndDateTime <DateTime?>]`: 
    - `[ScheduleStartDateTime <DateTime?>]`: 
    - `[ScheduleType <String>]`: 
    - `[SettingApprovalOnElevation <Boolean?>]`: 
    - `[SettingApproverIds <String[]>]`: 
    - `[SettingElevationDuration <TimeSpan?>]`: 
    - `[SettingId <String>]`: Read-only.
    - `[SettingIsMfaOnElevationConfigurable <Boolean?>]`: 
    - `[SettingLastGlobalAdmin <Boolean?>]`: 
    - `[SettingMaxElavationDuration <TimeSpan?>]`: 
    - `[SettingMfaOnElevation <Boolean?>]`: 
    - `[SettingMinElevationDuration <TimeSpan?>]`: 
    - `[SettingNotificationToUserOnElevation <Boolean?>]`: 
    - `[SettingTicketingInfoOnElevation <Boolean?>]`: 
    - `[Status <String>]`: 
    - `[SummaryElevatedCount <Int32?>]`: 
    - `[SummaryId <String>]`: Read-only.
    - `[SummaryManagedCount <Int32?>]`: 
    - `[SummaryMfaEnabled <Boolean?>]`: 
    - `[SummaryStatus <String>]`: roleSummaryStatus
    - `[SummaryUsersCount <Int32?>]`: 
    - `[TicketNumber <String>]`: 
    - `[TicketSystem <String>]`: 
    - `[Type <String>]`: 
    - `[UserId <String>]`: 
  - `[RequestorReason <String>]`: 
  - `[RoleId <String>]`: 
  - `[RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
  - `[RoleInfoId <String>]`: Read-only.
  - `[RoleInfoName <String>]`: 
  - `[SettingApprovalOnElevation <Boolean?>]`: 
  - `[SettingApproverIds <String[]>]`: 
  - `[SettingElevationDuration <TimeSpan?>]`: 
  - `[SettingId <String>]`: Read-only.
  - `[SettingIsMfaOnElevationConfigurable <Boolean?>]`: 
  - `[SettingLastGlobalAdmin <Boolean?>]`: 
  - `[SettingMaxElavationDuration <TimeSpan?>]`: 
  - `[SettingMfaOnElevation <Boolean?>]`: 
  - `[SettingMinElevationDuration <TimeSpan?>]`: 
  - `[SettingNotificationToUserOnElevation <Boolean?>]`: 
  - `[SettingTicketingInfoOnElevation <Boolean?>]`: 
  - `[StartDateTime <DateTime?>]`: 
  - `[SummaryElevatedCount <Int32?>]`: 
  - `[SummaryId <String>]`: Read-only.
  - `[SummaryManagedCount <Int32?>]`: 
  - `[SummaryMfaEnabled <Boolean?>]`: 
  - `[SummaryStatus <String>]`: roleSummaryStatus
  - `[SummaryUsersCount <Int32?>]`: 
  - `[UserId <String>]`: 

#### REQUEST <IMicrosoftGraphPrivilegedRoleAssignmentRequest>: privilegedRoleAssignmentRequest
  - `[Id <String>]`: Read-only.
  - `[AssignmentState <String>]`: 
  - `[Duration <String>]`: 
  - `[Reason <String>]`: 
  - `[RequestedDateTime <DateTime?>]`: 
  - `[RoleId <String>]`: 
  - `[RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ExpirationDateTime <DateTime?>]`: 
    - `[IsElevated <Boolean?>]`: 
    - `[ResultMessage <String>]`: 
    - `[RoleId <String>]`: 
    - `[RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
    - `[RoleInfoId <String>]`: Read-only.
    - `[RoleInfoName <String>]`: 
    - `[SettingApprovalOnElevation <Boolean?>]`: 
    - `[SettingApproverIds <String[]>]`: 
    - `[SettingElevationDuration <TimeSpan?>]`: 
    - `[SettingId <String>]`: Read-only.
    - `[SettingIsMfaOnElevationConfigurable <Boolean?>]`: 
    - `[SettingLastGlobalAdmin <Boolean?>]`: 
    - `[SettingMaxElavationDuration <TimeSpan?>]`: 
    - `[SettingMfaOnElevation <Boolean?>]`: 
    - `[SettingMinElevationDuration <TimeSpan?>]`: 
    - `[SettingNotificationToUserOnElevation <Boolean?>]`: 
    - `[SettingTicketingInfoOnElevation <Boolean?>]`: 
    - `[SummaryElevatedCount <Int32?>]`: 
    - `[SummaryId <String>]`: Read-only.
    - `[SummaryManagedCount <Int32?>]`: 
    - `[SummaryMfaEnabled <Boolean?>]`: 
    - `[SummaryStatus <String>]`: roleSummaryStatus
    - `[SummaryUsersCount <Int32?>]`: 
    - `[UserId <String>]`: 
  - `[RoleInfoId <String>]`: Read-only.
  - `[RoleInfoName <String>]`: 
  - `[ScheduleDuration <TimeSpan?>]`: 
  - `[ScheduleEndDateTime <DateTime?>]`: 
  - `[ScheduleStartDateTime <DateTime?>]`: 
  - `[ScheduleType <String>]`: 
  - `[SettingApprovalOnElevation <Boolean?>]`: 
  - `[SettingApproverIds <String[]>]`: 
  - `[SettingElevationDuration <TimeSpan?>]`: 
  - `[SettingId <String>]`: Read-only.
  - `[SettingIsMfaOnElevationConfigurable <Boolean?>]`: 
  - `[SettingLastGlobalAdmin <Boolean?>]`: 
  - `[SettingMaxElavationDuration <TimeSpan?>]`: 
  - `[SettingMfaOnElevation <Boolean?>]`: 
  - `[SettingMinElevationDuration <TimeSpan?>]`: 
  - `[SettingNotificationToUserOnElevation <Boolean?>]`: 
  - `[SettingTicketingInfoOnElevation <Boolean?>]`: 
  - `[Status <String>]`: 
  - `[SummaryElevatedCount <Int32?>]`: 
  - `[SummaryId <String>]`: Read-only.
  - `[SummaryManagedCount <Int32?>]`: 
  - `[SummaryMfaEnabled <Boolean?>]`: 
  - `[SummaryStatus <String>]`: roleSummaryStatus
  - `[SummaryUsersCount <Int32?>]`: 
  - `[TicketNumber <String>]`: 
  - `[TicketSystem <String>]`: 
  - `[Type <String>]`: 
  - `[UserId <String>]`: 

#### ROLEINFOASSIGNMENTS <IMicrosoftGraphPrivilegedRoleAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[ExpirationDateTime <DateTime?>]`: 
  - `[IsElevated <Boolean?>]`: 
  - `[ResultMessage <String>]`: 
  - `[RoleId <String>]`: 
  - `[RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
  - `[RoleInfoId <String>]`: Read-only.
  - `[RoleInfoName <String>]`: 
  - `[SettingApprovalOnElevation <Boolean?>]`: 
  - `[SettingApproverIds <String[]>]`: 
  - `[SettingElevationDuration <TimeSpan?>]`: 
  - `[SettingId <String>]`: Read-only.
  - `[SettingIsMfaOnElevationConfigurable <Boolean?>]`: 
  - `[SettingLastGlobalAdmin <Boolean?>]`: 
  - `[SettingMaxElavationDuration <TimeSpan?>]`: 
  - `[SettingMfaOnElevation <Boolean?>]`: 
  - `[SettingMinElevationDuration <TimeSpan?>]`: 
  - `[SettingNotificationToUserOnElevation <Boolean?>]`: 
  - `[SettingTicketingInfoOnElevation <Boolean?>]`: 
  - `[SummaryElevatedCount <Int32?>]`: 
  - `[SummaryId <String>]`: Read-only.
  - `[SummaryManagedCount <Int32?>]`: 
  - `[SummaryMfaEnabled <Boolean?>]`: 
  - `[SummaryStatus <String>]`: roleSummaryStatus
  - `[SummaryUsersCount <Int32?>]`: 
  - `[UserId <String>]`: 

## RELATED LINKS

