---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/new-mgprivilegedrole
schema: 2.0.0
---

# New-MgPrivilegedRole

## SYNOPSIS
Add new entity to privilegedRoles

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrivilegedRole [-Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-Id <String>]
 [-Name <String>] [-SettingApprovalOnElevation] [-SettingApproverIds <String[]>]
 [-SettingElevationDuration <TimeSpan>] [-SettingId <String>] [-SettingIsMfaOnElevationConfigurable]
 [-SettingLastGlobalAdmin] [-SettingMaxElavationDuration <TimeSpan>] [-SettingMfaOnElevation]
 [-SettingMinElevationDuration <TimeSpan>] [-SettingNotificationToUserOnElevation]
 [-SettingTicketingInfoOnElevation] [-SummaryElevatedCount <Int32>] [-SummaryId <String>]
 [-SummaryManagedCount <Int32>] [-SummaryMfaEnabled] [-SummaryStatus <String>] [-SummaryUsersCount <Int32>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgPrivilegedRole -BodyParameter <IMicrosoftGraphPrivilegedRole> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to privilegedRoles

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

### -Assignments
.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

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

### -BodyParameter
privilegedRole
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Name
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ASSIGNMENTS <IMicrosoftGraphPrivilegedRoleAssignment[]>: .
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

#### BODYPARAMETER <IMicrosoftGraphPrivilegedRole>: privilegedRole
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: 
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
  - `[Name <String>]`: 
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

## RELATED LINKS

