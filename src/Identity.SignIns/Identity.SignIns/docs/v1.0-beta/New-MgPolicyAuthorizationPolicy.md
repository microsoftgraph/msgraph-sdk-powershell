---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicyauthorizationpolicy
schema: 2.0.0
---

# New-MgPolicyAuthorizationPolicy

## SYNOPSIS
Create new navigation property to authorizationPolicy for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyAuthorizationPolicy [-AdditionalProperties <Hashtable>] [-AllowedToSignUpEmailBasedSubscriptions]
 [-AllowedToUseSspr] [-AllowEmailVerifiedUsersToJoinOrganization] [-AllowInvitesFrom <String>]
 [-BlockMsolPowerShell] [-DefaultUserRoleOverrides <IMicrosoftGraphDefaultUserRoleOverride[]>]
 [-DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions1>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-EnabledPreviewFeatures <String[]>]
 [-GuestUserRoleId <String>] [-Id <String>] [-PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgPolicyAuthorizationPolicy -BodyParameter <IMicrosoftGraphAuthorizationPolicy1> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to authorizationPolicy for policies

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

### -AllowedToSignUpEmailBasedSubscriptions
Indicates whether users can sign up for email based subscriptions.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedToUseSspr
Indicates whether the Self-Serve Password Reset feature can be used by users on the tenant.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowEmailVerifiedUsersToJoinOrganization
Indicates whether a user can join the tenant by email validation.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowInvitesFrom
allowInvitesFrom

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

### -BlockMsolPowerShell
To disable the use of MSOL PowerShell set this property to true.
This will also disable user-based access to the legacy service endpoint used by MSOL PowerShell.
This does not affect Azure AD Connect or Microsoft Graph.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
authorizationPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultUserRoleOverrides
.
To construct, please use Get-Help -Online and see NOTES section for DEFAULTUSERROLEOVERRIDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultUserRoleOverride[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultUserRolePermissions
defaultUserRolePermissions
To construct, please use Get-Help -Online and see NOTES section for DEFAULTUSERROLEPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDefaultUserRolePermissions1
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

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

### -Description
Description for this policy.
Required.

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

### -DisplayName
Display name for this policy.
Required.

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

### -EnabledPreviewFeatures
List of features enabled for private preview on the tenant.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuestUserRoleId
Represents role templateId for the role that should be granted to guest user.
Refer to List unifiedRoleDefinitions to find the list of available role templates.
Currently following roles are supported: User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).

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

### -PermissionGrantPolicyIdsAssignedToDefaultUserRole
Indicates if user consent to apps is allowed, and if it is, which app consent policy (permissionGrantPolicy) governs the permission for users to grant consent.
Values should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy.
An empty list indicates user consent to apps is disabled.

```yaml
Type: System.String[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAuthorizationPolicy1>: authorizationPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[AllowEmailVerifiedUsersToJoinOrganization <Boolean?>]`: Indicates whether a user can join the tenant by email validation.
  - `[AllowInvitesFrom <String>]`: allowInvitesFrom
  - `[AllowedToSignUpEmailBasedSubscriptions <Boolean?>]`: Indicates whether users can sign up for email based subscriptions.
  - `[AllowedToUseSspr <Boolean?>]`: Indicates whether the Self-Serve Password Reset feature can be used by users on the tenant.
  - `[BlockMsolPowerShell <Boolean?>]`: To disable the use of MSOL PowerShell set this property to true. This will also disable user-based access to the legacy service endpoint used by MSOL PowerShell. This does not affect Azure AD Connect or Microsoft Graph.
  - `[DefaultUserRoleOverrides <IMicrosoftGraphDefaultUserRoleOverride[]>]`: 
    - `[Id <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
      - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
      - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
      - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.
  - `[DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions1>]`: defaultUserRolePermissions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedToCreateApps <Boolean?>]`: Indicates whether the default user role can create applications.
    - `[AllowedToCreateSecurityGroups <Boolean?>]`: Indicates whether the default user role can create security groups.
    - `[AllowedToReadOtherUsers <Boolean?>]`: Indicates whether the default user role can read other users.
  - `[EnabledPreviewFeatures <String[]>]`: List of features enabled for private preview on the tenant.
  - `[GuestUserRoleId <String>]`: Represents role templateId for the role that should be granted to guest user. Refer to List unifiedRoleDefinitions to find the list of available role templates. Currently following roles are supported:  User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).
  - `[PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]`: Indicates if user consent to apps is allowed, and if it is, which app consent policy (permissionGrantPolicy) governs the permission for users to grant consent. Values should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.

DEFAULTUSERROLEOVERRIDES <IMicrosoftGraphDefaultUserRoleOverride[]>: .
  - `[Id <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
    - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
    - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective.
    - `[ExcludedResourceActions <String[]>]`: Set of tasks that may not be performed on a resource. Not yet supported.

DEFAULTUSERROLEPERMISSIONS <IMicrosoftGraphDefaultUserRolePermissions1>: defaultUserRolePermissions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedToCreateApps <Boolean?>]`: Indicates whether the default user role can create applications.
  - `[AllowedToCreateSecurityGroups <Boolean?>]`: Indicates whether the default user role can create security groups.
  - `[AllowedToReadOtherUsers <Boolean?>]`: Indicates whether the default user role can read other users.

## RELATED LINKS

