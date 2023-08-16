---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetapolicyauthorizationpolicy
schema: 2.0.0
---

# New-MgBetaPolicyAuthorizationPolicy

## SYNOPSIS
Create new navigation property to authorizationPolicy for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPolicyAuthorizationPolicy [-AdditionalProperties <Hashtable>]
 [-AllowedToSignUpEmailBasedSubscriptions] [-AllowedToUseSspr] [-AllowEmailVerifiedUsersToJoinOrganization]
 [-AllowInvitesFrom <String>] [-AllowUserConsentForRiskyApps] [-BlockMsolPowerShell]
 [-DefaultUserRoleOverrides <IMicrosoftGraphDefaultUserRoleOverride[]>]
 [-DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-EnabledPreviewFeatures <String[]>]
 [-GuestUserRoleId <String>] [-Id <String>] [-PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaPolicyAuthorizationPolicy -BodyParameter <IMicrosoftGraphAuthorizationPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to authorizationPolicy for policies

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
Indicates whether the Admin Self-Serve Password Reset feature is enabled on the tenant.

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

### -AllowUserConsentForRiskyApps
Indicates whether user consent for risky apps is allowed.
Default value is false.
We recommend that you keep the value set to false.

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

### -BlockMsolPowerShell
To disable the use of the MSOnline PowerShell module set this property to true.
This will also disable user-based access to the legacy service endpoint used by the MSOnline PowerShell module.
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy
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
To construct, see NOTES section for DEFAULTUSERROLEOVERRIDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDefaultUserRoleOverride[]
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
To construct, see NOTES section for DEFAULTUSERROLEPERMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDefaultUserRolePermissions
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
The unique identifier for an entity.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthorizationPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAuthorizationPolicy>`: authorizationPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowEmailVerifiedUsersToJoinOrganization <Boolean?>]`: Indicates whether a user can join the tenant by email validation.
  - `[AllowInvitesFrom <String>]`: allowInvitesFrom
  - `[AllowUserConsentForRiskyApps <Boolean?>]`: Indicates whether user consent for risky apps is allowed. Default value is false. We recommend that you keep the value set to false.
  - `[AllowedToSignUpEmailBasedSubscriptions <Boolean?>]`: Indicates whether users can sign up for email based subscriptions.
  - `[AllowedToUseSspr <Boolean?>]`: Indicates whether the Admin Self-Serve Password Reset feature is enabled on the tenant.
  - `[BlockMsolPowerShell <Boolean?>]`: To disable the use of the MSOnline PowerShell module set this property to true. This will also disable user-based access to the legacy service endpoint used by the MSOnline PowerShell module. This does not affect Azure AD Connect or Microsoft Graph.
  - `[DefaultUserRoleOverrides <IMicrosoftGraphDefaultUserRoleOverride[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[IsDefault <Boolean?>]`: 
    - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
      - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
      - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective. Not supported for custom roles.
      - `[ExcludedResourceActions <String[]>]`: 
  - `[DefaultUserRolePermissions <IMicrosoftGraphDefaultUserRolePermissions>]`: defaultUserRolePermissions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowedToCreateApps <Boolean?>]`: Indicates whether the default user role can create applications. This setting corresponds to the Users can register applications setting in the User settings menu in the Azure portal.
    - `[AllowedToCreateSecurityGroups <Boolean?>]`: Indicates whether the default user role can create security groups. This setting corresponds to the following menus in the Azure portal:  The Users can create security groups in Azure portals, API or PowerShell setting in the Group settings menu.  Users can create security groups setting in the User settings menu.
    - `[AllowedToCreateTenants <Boolean?>]`: Indicates whether the default user role can create tenants. This setting corresponds to the Restrict non-admin users from creating tenants setting in the User settings menu in the Azure portal. When this setting is false, users assigned the Tenant Creator role can still create tenants.
    - `[AllowedToReadBitlockerKeysForOwnedDevice <Boolean?>]`: Indicates whether the registered owners of a device can read their own BitLocker recovery keys with default user role.
    - `[AllowedToReadOtherUsers <Boolean?>]`: Indicates whether the default user role can read other users. DO NOT SET THIS VALUE TO false.
  - `[EnabledPreviewFeatures <String[]>]`: List of features enabled for private preview on the tenant.
  - `[GuestUserRoleId <String>]`: Represents role templateId for the role that should be granted to guest user. Refer to List unifiedRoleDefinitions to find the list of available role templates. Currently following roles are supported:  User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).
  - `[PermissionGrantPolicyIdsAssignedToDefaultUserRole <String[]>]`: Indicates if user consent to apps is allowed, and if it is, which app consent policy (permissionGrantPolicy) governs the permission for users to grant consent. Values should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.

`DEFAULTUSERROLEOVERRIDES <IMicrosoftGraphDefaultUserRoleOverride[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[IsDefault <Boolean?>]`: 
  - `[RolePermissions <IMicrosoftGraphUnifiedRolePermission[]>]`: 
    - `[AllowedResourceActions <String[]>]`: Set of tasks that can be performed on a resource.
    - `[Condition <String>]`: Optional constraints that must be met for the permission to be effective. Not supported for custom roles.
    - `[ExcludedResourceActions <String[]>]`: 

`DEFAULTUSERROLEPERMISSIONS <IMicrosoftGraphDefaultUserRolePermissions>`: defaultUserRolePermissions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowedToCreateApps <Boolean?>]`: Indicates whether the default user role can create applications. This setting corresponds to the Users can register applications setting in the User settings menu in the Azure portal.
  - `[AllowedToCreateSecurityGroups <Boolean?>]`: Indicates whether the default user role can create security groups. This setting corresponds to the following menus in the Azure portal:  The Users can create security groups in Azure portals, API or PowerShell setting in the Group settings menu.  Users can create security groups setting in the User settings menu.
  - `[AllowedToCreateTenants <Boolean?>]`: Indicates whether the default user role can create tenants. This setting corresponds to the Restrict non-admin users from creating tenants setting in the User settings menu in the Azure portal. When this setting is false, users assigned the Tenant Creator role can still create tenants.
  - `[AllowedToReadBitlockerKeysForOwnedDevice <Boolean?>]`: Indicates whether the registered owners of a device can read their own BitLocker recovery keys with default user role.
  - `[AllowedToReadOtherUsers <Boolean?>]`: Indicates whether the default user role can read other users. DO NOT SET THIS VALUE TO false.

## RELATED LINKS

