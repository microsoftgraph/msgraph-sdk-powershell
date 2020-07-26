---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/update-mgprivilegedapproval
schema: 2.0.0
---

# Update-MgPrivilegedApproval

## SYNOPSIS
Update entity in privilegedApproval

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedApproval -PrivilegedApprovalId <String> [-ApprovalDuration <TimeSpan>]
 [-ApprovalState <String>] [-ApprovalType <String>] [-ApproverReason <String>] [-EndDateTime <DateTime>]
 [-Id <String>] [-Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>] [-RequestorReason <String>]
 [-RoleId <String>] [-RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-RoleInfoId <String>]
 [-RoleInfoName <String>] [-SettingApprovalOnElevation] [-SettingApproverIds <String[]>]
 [-SettingElevationDuration <TimeSpan>] [-SettingId <String>] [-SettingIsMfaOnElevationConfigurable]
 [-SettingLastGlobalAdmin] [-SettingMaxElavationDuration <TimeSpan>] [-SettingMfaOnElevation]
 [-SettingMinElevationDuration <TimeSpan>] [-SettingNotificationToUserOnElevation]
 [-SettingTicketingInfoOnElevation] [-StartDateTime <DateTime>] [-SummaryElevatedCount <Int32>]
 [-SummaryId <String>] [-SummaryManagedCount <Int32>] [-SummaryMfaEnabled] [-SummaryStatus <String>]
 [-SummaryUsersCount <Int32>] [-UserId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedApproval -PrivilegedApprovalId <String> -BodyParameter <IMicrosoftGraphPrivilegedApproval>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedApproval -InputObject <IIdentityAzureAdpimIdentity>
 -BodyParameter <IMicrosoftGraphPrivilegedApproval> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedApproval -InputObject <IIdentityAzureAdpimIdentity> [-ApprovalDuration <TimeSpan>]
 [-ApprovalState <String>] [-ApprovalType <String>] [-ApproverReason <String>] [-EndDateTime <DateTime>]
 [-Id <String>] [-Request <IMicrosoftGraphPrivilegedRoleAssignmentRequest>] [-RequestorReason <String>]
 [-RoleId <String>] [-RoleInfoAssignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-RoleInfoId <String>]
 [-RoleInfoName <String>] [-SettingApprovalOnElevation] [-SettingApproverIds <String[]>]
 [-SettingElevationDuration <TimeSpan>] [-SettingId <String>] [-SettingIsMfaOnElevationConfigurable]
 [-SettingLastGlobalAdmin] [-SettingMaxElavationDuration <TimeSpan>] [-SettingMfaOnElevation]
 [-SettingMinElevationDuration <TimeSpan>] [-SettingNotificationToUserOnElevation]
 [-SettingTicketingInfoOnElevation] [-StartDateTime <DateTime>] [-SummaryElevatedCount <Int32>]
 [-SummaryId <String>] [-SummaryManagedCount <Int32>] [-SummaryMfaEnabled] [-SummaryStatus <String>]
 [-SummaryUsersCount <Int32>] [-UserId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update entity in privilegedApproval

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

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
.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAzureAdpimIdentity
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
key: privilegedApproval-id of privilegedApproval

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
To construct, see NOTES section for REQUEST properties and create a hash table.

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

### -RoleInfoAssignments
.
To construct, see NOTES section for ROLEINFOASSIGNMENTS properties and create a hash table.

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

### -RoleInfoId
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

### -RoleInfoName
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

### -SettingApprovalOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingApproverIds
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingElevationDuration
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

### -SettingId
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

### -SettingIsMfaOnElevationConfigurable
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingLastGlobalAdmin
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingMaxElavationDuration
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

### -SettingMfaOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingMinElevationDuration
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

### -SettingNotificationToUserOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SettingTicketingInfoOnElevation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SummaryElevatedCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SummaryId
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

### -SummaryManagedCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SummaryMfaEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SummaryStatus
roleSummaryStatus

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

### -SummaryUsersCount
.

```yaml
Type: System.Int32
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

### Microsoft.Graph.PowerShell.Models.IIdentityAzureAdpimIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedApproval

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrivilegedApproval>: privilegedApproval
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

INPUTOBJECT <IIdentityAzureAdpimIdentity>: Identity Parameter
  - `[PrivilegedApprovalId <String>]`: key: privilegedApproval-id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: privilegedOperationEvent-id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: privilegedRoleAssignment-id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: privilegedRoleAssignmentRequest-id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: privilegedRole-id of privilegedRole

REQUEST <IMicrosoftGraphPrivilegedRoleAssignmentRequest>: privilegedRoleAssignmentRequest
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

ROLEINFOASSIGNMENTS <IMicrosoftGraphPrivilegedRoleAssignment[]>: .
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

