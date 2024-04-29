---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementresourcerolescope
schema: 2.0.0
---

# New-MgEntitlementManagementResourceRoleScope

## SYNOPSIS
Create new navigation property to resourceRoleScopes for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementResourceRoleScope [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>]
 [-Id <String>] [-Role <IMicrosoftGraphAccessPackageResourceRole>]
 [-Scope <IMicrosoftGraphAccessPackageResourceScope>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementResourceRoleScope -BodyParameter <IMicrosoftGraphAccessPackageResourceRoleScope>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to resourceRoleScopes for identityGovernance

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



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
accessPackageResourceRoleScope
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

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

### -Role
accessPackageResourceRole
To construct, see NOTES section for ROLE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRole
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scope
accessPackageResourceScope
To construct, see NOTES section for SCOPE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceScope
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRoleScope

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAccessPackageResourceRoleScope>`: accessPackageResourceRoleScope
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Role <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: A description for the resource role.
    - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
    - `[OriginId <String>]`: The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: A description for the resource.
      - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
      - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Description <String>]`: The description of this object.
        - `[DisplayName <String>]`: The display name of this object.
        - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Microsoft Entra groups and Microsoft Entra Applications.
        - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
        - `[OriginSystem <String>]`: The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).
        - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of a Microsoft Entra group, this is the identifier of the group.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
      - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable. Supports $expand.
      - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable. Supports $expand.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Description <String>]`: The description of the scope.
        - `[DisplayName <String>]`: The display name of the scope.
        - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
        - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
        - `[OriginSystem <String>]`: The origin system for the scope.
        - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
  - `[Scope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope

`ROLE <IMicrosoftGraphAccessPackageResourceRole>`: accessPackageResourceRole
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: A description for the resource role.
  - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
  - `[OriginId <String>]`: The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.
  - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
  - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: A description for the resource.
    - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
    - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of this object.
      - `[DisplayName <String>]`: The display name of this object.
      - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Microsoft Entra groups and Microsoft Entra Applications.
      - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).
      - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of a Microsoft Entra group, this is the identifier of the group.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable. Supports $expand.
    - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: The description of the scope.
      - `[DisplayName <String>]`: The display name of the scope.
      - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
      - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
      - `[OriginSystem <String>]`: The origin system for the scope.
      - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource

`SCOPE <IMicrosoftGraphAccessPackageResourceScope>`: accessPackageResourceScope
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the scope.
  - `[DisplayName <String>]`: The display name of the scope.
  - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
  - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
  - `[OriginSystem <String>]`: The origin system for the scope.
  - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: A description for the resource.
    - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
    - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of this object.
      - `[DisplayName <String>]`: The display name of this object.
      - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Microsoft Entra groups and Microsoft Entra Applications.
      - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, that is, SharePointOnline. Requires $filter (eq).
      - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of a Microsoft Entra group, this is the identifier of the group.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable. Supports $expand.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Description <String>]`: A description for the resource role.
      - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
      - `[OriginId <String>]`: The unique identifier of the resource role in the origin system. For a SharePoint Online site, the originId will be the sequence number of the role in the site.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
      - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable. Supports $expand.

## RELATED LINKS

