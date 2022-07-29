---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprivilegedrole
schema: 2.0.0
---

# New-MgPrivilegedRole

## SYNOPSIS
Add new entity to privilegedRoles

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrivilegedRole [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>] [-Id <String>] [-Name <String>]
 [-Settings <IMicrosoftGraphPrivilegedRoleSettings>] [-Summary <IMicrosoftGraphPrivilegedRoleSummary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgPrivilegedRole -BodyParameter <IMicrosoftGraphPrivilegedRole> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to privilegedRoles

## EXAMPLES

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

### -Assignments
The assignments for this role.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleAssignment[]
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -Name
Role name.

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

### -Settings
privilegedRoleSettings
To construct, please use Get-Help -Online and see NOTES section for SETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRoleSettings
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrivilegedRole

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphPrivilegedRoleAssignment[]>: The assignments for this role. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[ExpirationDateTime <DateTime?>]`: The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.
  - `[IsElevated <Boolean?>]`: true if the role assignment is activated. false if the role assignment is deactivated.
  - `[ResultMessage <String>]`: Result message set by the service.
  - `[RoleId <String>]`: Role identifier. In GUID string format.
  - `[RoleInfo <IMicrosoftGraphPrivilegedRole>]`: privilegedRole
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphPrivilegedRoleAssignment[]>]`: The assignments for this role. Read-only. Nullable.
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
  - `[UserId <String>]`: User identifier. In GUID string format.

BODYPARAMETER <IMicrosoftGraphPrivilegedRole>: privilegedRole
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

SETTINGS <IMicrosoftGraphPrivilegedRoleSettings>: privilegedRoleSettings
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

SUMMARY <IMicrosoftGraphPrivilegedRoleSummary>: privilegedRoleSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ElevatedCount <Int32?>]`: The number of users that have the role assigned and the role is activated.
  - `[ManagedCount <Int32?>]`: The number of users that have the role assigned but the role is deactivated.
  - `[MfaEnabled <Boolean?>]`: true if the role activation requires MFA. false if the role activation doesn't require MFA.
  - `[Status <String>]`: roleSummaryStatus
  - `[UsersCount <Int32?>]`: The number of users that are assigned with the role.

## RELATED LINKS

