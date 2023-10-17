---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.signins/new-mgpolicypermissiongrantpolicy
schema: 2.0.0
---

# New-MgPolicyPermissionGrantPolicy

## SYNOPSIS
Creates a permissionGrantPolicy.
A permission grant policy is used to describe the conditions under which permissions can be granted (for example, during application consent).
After creating the permission grant policy, you can add include condition sets to add matching rules, and add exclude condition sets to add exclusion rules.
This API is available in the following national cloud deployments.

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyPermissionGrantPolicy [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Excludes <IMicrosoftGraphPermissionGrantConditionSet[]>]
 [-Id <String>] [-Includes <IMicrosoftGraphPermissionGrantConditionSet[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgPolicyPermissionGrantPolicy -BodyParameter <IMicrosoftGraphPermissionGrantPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Creates a permissionGrantPolicy.
A permission grant policy is used to describe the conditions under which permissions can be granted (for example, during application consent).
After creating the permission grant policy, you can add include condition sets to add matching rules, and add exclude condition sets to add exclusion rules.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Connect-MgGraph -Scopes "Policy.Read.PermissionGrant,Policy.ReadWrite.PermissionGrant"  
New-MgPolicyPermissionGrantPolicy -Id "testtenant-sampleapp-permissions" -Description "Permissions for sample app in test tenant" -DisplayName "Sample app permissions" | fl
```

DeletedDateTime      :
Description          : Permissions for sample app in test tenant
DisplayName          : Sample app permissions
Excludes             :
Id                   : testtenant-sampleapp-permissions
Includes             :
AdditionalProperties : {[@odata.context, https://graph.microsoft.com/v1.0/$metadata#policies/permissionGrantPolicies/$entity]}

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

### -BodyParameter
permissionGrantPolicy
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Excludes
Condition sets which are excluded in this permission grant policy.
Automatically expanded on GET.
To construct, see NOTES section for EXCLUDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet[]
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

### -Includes
Condition sets which are included in this permission grant policy.
Automatically expanded on GET.
To construct, see NOTES section for INCLUDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPermissionGrantPolicy>`: permissionGrantPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Excludes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: Condition sets which are excluded in this permission grant policy. Automatically expanded on GET.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ClientApplicationIds <String[]>]`: A list of appId values for the client applications to match with, or a list with the single value all to match any client application. Default is the single value all.
    - `[ClientApplicationPublisherIds <String[]>]`: A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher. Default is the single value all.
    - `[ClientApplicationTenantIds <String[]>]`: A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant. Default is the single value all.
    - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: Set to true to only match on client applications with a verified publisher. Set to false to match on any client app, even if it doesn't have a verified publisher. Default is false.
    - `[PermissionClassification <String>]`: The permission classification for the permission being granted, or all to match with any permission classification (including permissions that aren't classified). Default is all.
    - `[PermissionType <String>]`: permissionType
    - `[Permissions <String[]>]`: The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission. The id of delegated permissions can be found in the oauth2PermissionScopes property of the API's servicePrincipal object. The id of application permissions can be found in the appRoles property of the API's servicePrincipal object. The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's servicePrincipal object. Default is the single value all.
    - `[ResourceApplication <String>]`: The appId of the resource application (for example the API) for which a permission is being granted, or any to match with any resource application or API. Default is any.
  - `[Includes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: Condition sets which are included in this permission grant policy. Automatically expanded on GET.

`EXCLUDES <IMicrosoftGraphPermissionGrantConditionSet[]>`: Condition sets which are excluded in this permission grant policy. Automatically expanded on GET.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ClientApplicationIds <String[]>]`: A list of appId values for the client applications to match with, or a list with the single value all to match any client application. Default is the single value all.
  - `[ClientApplicationPublisherIds <String[]>]`: A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher. Default is the single value all.
  - `[ClientApplicationTenantIds <String[]>]`: A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant. Default is the single value all.
  - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: Set to true to only match on client applications with a verified publisher. Set to false to match on any client app, even if it doesn't have a verified publisher. Default is false.
  - `[PermissionClassification <String>]`: The permission classification for the permission being granted, or all to match with any permission classification (including permissions that aren't classified). Default is all.
  - `[PermissionType <String>]`: permissionType
  - `[Permissions <String[]>]`: The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission. The id of delegated permissions can be found in the oauth2PermissionScopes property of the API's servicePrincipal object. The id of application permissions can be found in the appRoles property of the API's servicePrincipal object. The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's servicePrincipal object. Default is the single value all.
  - `[ResourceApplication <String>]`: The appId of the resource application (for example the API) for which a permission is being granted, or any to match with any resource application or API. Default is any.

`INCLUDES <IMicrosoftGraphPermissionGrantConditionSet[]>`: Condition sets which are included in this permission grant policy. Automatically expanded on GET.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ClientApplicationIds <String[]>]`: A list of appId values for the client applications to match with, or a list with the single value all to match any client application. Default is the single value all.
  - `[ClientApplicationPublisherIds <String[]>]`: A list of Microsoft Partner Network (MPN) IDs for verified publishers of the client application, or a list with the single value all to match with client apps from any publisher. Default is the single value all.
  - `[ClientApplicationTenantIds <String[]>]`: A list of Azure Active Directory tenant IDs in which the client application is registered, or a list with the single value all to match with client apps registered in any tenant. Default is the single value all.
  - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: Set to true to only match on client applications with a verified publisher. Set to false to match on any client app, even if it doesn't have a verified publisher. Default is false.
  - `[PermissionClassification <String>]`: The permission classification for the permission being granted, or all to match with any permission classification (including permissions that aren't classified). Default is all.
  - `[PermissionType <String>]`: permissionType
  - `[Permissions <String[]>]`: The list of id values for the specific permissions to match with, or a list with the single value all to match with any permission. The id of delegated permissions can be found in the oauth2PermissionScopes property of the API's servicePrincipal object. The id of application permissions can be found in the appRoles property of the API's servicePrincipal object. The id of resource-specific application permissions can be found in the resourceSpecificApplicationPermissions property of the API's servicePrincipal object. Default is the single value all.
  - `[ResourceApplication <String>]`: The appId of the resource application (for example the API) for which a permission is being granted, or any to match with any resource application or API. Default is any.

## RELATED LINKS

