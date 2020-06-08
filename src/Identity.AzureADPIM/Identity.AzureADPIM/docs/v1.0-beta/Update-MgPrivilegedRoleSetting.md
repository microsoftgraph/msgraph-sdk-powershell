---
external help file:
Module Name: Microsoft.Graph.Identity.AzureADPIM
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.azureadpim/update-mgprivilegedrolesetting
schema: 2.0.0
---

# Update-MgPrivilegedRoleSetting

## SYNOPSIS
Update the navigation property settings in privilegedRoles

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrivilegedRoleSetting -PrivilegedRoleId <String> [-ApprovalOnElevation] [-ApproverIds <String[]>]
 [-ElevationDuration <TimeSpan>] [-Id <String>] [-IsMfaOnElevationConfigurable] [-LastGlobalAdmin]
 [-MaxElavationDuration <TimeSpan>] [-MfaOnElevation] [-MinElevationDuration <TimeSpan>]
 [-NotificationToUserOnElevation] [-TicketingInfoOnElevation] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPrivilegedRoleSetting -PrivilegedRoleId <String>
 -BodyParameter <IMicrosoftGraphPrivilegedRoleSettings> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrivilegedRoleSetting -InputObject <IIdentityAzureAdpimIdentity>
 -BodyParameter <IMicrosoftGraphPrivilegedRoleSettings> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrivilegedRoleSetting -InputObject <IIdentityAzureAdpimIdentity> [-ApprovalOnElevation]
 [-ApproverIds <String[]>] [-ElevationDuration <TimeSpan>] [-Id <String>] [-IsMfaOnElevationConfigurable]
 [-LastGlobalAdmin] [-MaxElavationDuration <TimeSpan>] [-MfaOnElevation] [-MinElevationDuration <TimeSpan>]
 [-NotificationToUserOnElevation] [-TicketingInfoOnElevation] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property settings in privilegedRoles

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

### -ApprovalOnElevation
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

### -ApproverIds
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

### -BodyParameter
privilegedRoleSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleSettings
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ElevationDuration
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

### -IsMfaOnElevationConfigurable
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

### -LastGlobalAdmin
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

### -MaxElavationDuration
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

### -MfaOnElevation
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

### -MinElevationDuration
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

### -NotificationToUserOnElevation
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

### -PrivilegedRoleId
key: privilegedRole-id of privilegedRole

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

### -TicketingInfoOnElevation
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleSettings

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPrivilegedRoleSettings>: privilegedRoleSettings
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

INPUTOBJECT <IIdentityAzureAdpimIdentity>: Identity Parameter
  - `[PrivilegedApprovalId <String>]`: key: privilegedApproval-id of privilegedApproval
  - `[PrivilegedOperationEventId <String>]`: key: privilegedOperationEvent-id of privilegedOperationEvent
  - `[PrivilegedRoleAssignmentId <String>]`: key: privilegedRoleAssignment-id of privilegedRoleAssignment
  - `[PrivilegedRoleAssignmentRequestId <String>]`: key: privilegedRoleAssignmentRequest-id of privilegedRoleAssignmentRequest
  - `[PrivilegedRoleId <String>]`: key: privilegedRole-id of privilegedRole

## RELATED LINKS

