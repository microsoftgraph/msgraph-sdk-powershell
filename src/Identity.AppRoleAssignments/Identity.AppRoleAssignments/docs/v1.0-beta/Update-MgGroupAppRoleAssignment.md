---
external help file:
Module Name: Microsoft.Graph.Identity.AppRoleAssignments
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.approleassignments/update-mggroupapproleassignment
schema: 2.0.0
---

# Update-MgGroupAppRoleAssignment

## SYNOPSIS
Update the navigation property appRoleAssignments in groups

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgGroupAppRoleAssignment -AppRoleAssignmentId <String> -GroupId <String> [-AppRoleId <String>]
 [-CreationTimestamp <DateTime>] [-Id <String>] [-PrincipalDisplayName <String>] [-PrincipalId <String>]
 [-PrincipalType <String>] [-ResourceDisplayName <String>] [-ResourceId <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgGroupAppRoleAssignment -AppRoleAssignmentId <String> -GroupId <String>
 -BodyParameter <IMicrosoftGraphAppRoleAssignment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgGroupAppRoleAssignment -InputObject <IIdentityAppRoleAssignmentsIdentity>
 -BodyParameter <IMicrosoftGraphAppRoleAssignment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgGroupAppRoleAssignment -InputObject <IIdentityAppRoleAssignmentsIdentity> [-AppRoleId <String>]
 [-CreationTimestamp <DateTime>] [-Id <String>] [-PrincipalDisplayName <String>] [-PrincipalId <String>]
 [-PrincipalType <String>] [-ResourceDisplayName <String>] [-ResourceId <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property appRoleAssignments in groups

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

### -AppRoleAssignmentId
key: appRoleAssignment-id of appRoleAssignment

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppRoleId
The identifier (id) for the app role which is assigned to the principal.
This app role must be exposed in the appRoles property on the resource application's service principal (resourceId).
If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles.
Required on create.
Does not support $filter.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
appRoleAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreationTimestamp
The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Read-only.
Does not support $filter.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityAppRoleAssignmentsIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
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

### -PrincipalDisplayName
The display name of the user, group, or service principal that was granted the app role assignment.
Read-only.
Supports $filter (eq and startswith).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrincipalId
The unique identifier (id) for the user, group or service principal being granted the app role.
Required on create.
Does not support $filter.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrincipalType
The type of the assigned principal.
This can either be 'User', 'Group' or 'ServicePrincipal'.
Read-only.
Does not support $filter.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceDisplayName
The display name of the resource app's service principal to which the assignment is made.
Does not support $filter.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceId
The unique identifier (id) for the resource service principal for which the assignment is made.
Required on create.
Supports $filter (eq only).

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IIdentityAppRoleAssignmentsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppRoleAssignment

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAppRoleAssignment>: appRoleAssignment
  - `[Id <String>]`: Read-only.
  - `[AppRoleId <String>]`: The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create. Does not support $filter.
  - `[CreationTimestamp <DateTime?>]`: The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only. Does not support $filter.
  - `[PrincipalDisplayName <String>]`: The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
  - `[PrincipalId <String>]`: The unique identifier (id) for the user, group or service principal being granted the app role. Required on create. Does not support $filter.
  - `[PrincipalType <String>]`: The type of the assigned principal. This can either be 'User', 'Group' or 'ServicePrincipal'. Read-only. Does not support $filter.
  - `[ResourceDisplayName <String>]`: The display name of the resource app's service principal to which the assignment is made. Does not support $filter.
  - `[ResourceId <String>]`: The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).

INPUTOBJECT <IIdentityAppRoleAssignmentsIdentity>: Identity Parameter
  - `[AppRoleAssignmentId <String>]`: key: appRoleAssignment-id of appRoleAssignment
  - `[GroupId <String>]`: key: group-id of group
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

