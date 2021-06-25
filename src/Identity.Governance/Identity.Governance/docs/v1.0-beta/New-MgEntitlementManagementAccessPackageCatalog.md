---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementaccesspackagecatalog
schema: 2.0.0
---

# New-MgEntitlementManagementAccessPackageCatalog

## SYNOPSIS
Create new navigation property to accessPackageCatalogs for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementAccessPackageCatalog
 [-AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]
 [-AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]
 [-AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]
 [-AccessPackages <IMicrosoftGraphAccessPackage[]>] [-AdditionalProperties <Hashtable>]
 [-CatalogStatus <String>] [-CatalogType <String>] [-CreatedBy <String>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsExternallyVisible] [-ModifiedBy <String>]
 [-ModifiedDateTime <DateTime>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementAccessPackageCatalog -BodyParameter <IMicrosoftGraphAccessPackageCatalog> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to accessPackageCatalogs for identityGovernance

## EXAMPLES

## PARAMETERS

### -AccessPackageResourceRoles
.
To construct, see NOTES section for ACCESSPACKAGERESOURCEROLES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceRole[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResources
Read-only.
Nullable.
To construct, see NOTES section for ACCESSPACKAGERESOURCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackageResourceScopes
.
To construct, see NOTES section for ACCESSPACKAGERESOURCESCOPES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageResourceScope[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccessPackages
The access packages in this catalog.
Read-only.
Nullable.
To construct, see NOTES section for ACCESSPACKAGES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackage[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageCatalog
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAccessPackageCatalog
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CatalogStatus
Has the value Published if the access packages are available for management.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CatalogType
One of UserManaged or ServiceDefault.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
UPN of the user who created this resource.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The description of the access package catalog.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The display name of the access package catalog.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsExternallyVisible
Whether the access packages in this catalog can be requested by users outside of the tenant.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedBy
The UPN of the user who last modified this resource.
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
Read-only.

```yaml
Type: DateTime
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageCatalog

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCESSPACKAGERESOURCEROLES <IMicrosoftGraphAccessPackageResourceRole[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
      - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
      - `[CreatedBy <String>]`: The display name of the user that created this object.
      - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of this accessPackageResourceEnvironment object.
      - `[DisplayName <String>]`: The display name of this object.
      - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.
      - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
      - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system such as SharePointOnline. Supports $filter.
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable.
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: The description of the scope.
      - `[DisplayName <String>]`: The display name of the scope.
      - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
      - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
      - `[OriginSystem <String>]`: The origin system for the scope.
      - `[RoleOriginId <String>]`: The origin system for the role, if different.
      - `[Url <String>]`: A resource locator for the scope.
    - `[AddedBy <String>]`: Read-only.
    - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: 
      - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AttributeName <String>]`: 
      - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
    - `[Description <String>]`: A description for the resource.
    - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
    - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment.
    - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[ResourceType <String>]`: The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
    - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.
  - `[Description <String>]`: A description for the resource role.
  - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
  - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
  - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.

ACCESSPACKAGERESOURCES <IMicrosoftGraphAccessPackageResource[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
    - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
    - `[CreatedBy <String>]`: The display name of the user that created this object.
    - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Description <String>]`: The description of this accessPackageResourceEnvironment object.
    - `[DisplayName <String>]`: The display name of this object.
    - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.
    - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
    - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
    - `[OriginSystem <String>]`: The type of the resource in the origin system such as SharePointOnline. Supports $filter.
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Description <String>]`: A description for the resource role.
    - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
    - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Description <String>]`: The description of the scope.
    - `[DisplayName <String>]`: The display name of the scope.
    - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
    - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
    - `[OriginSystem <String>]`: The origin system for the scope.
    - `[RoleOriginId <String>]`: The origin system for the role, if different.
    - `[Url <String>]`: A resource locator for the scope.
  - `[AddedBy <String>]`: Read-only.
  - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: 
    - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AttributeName <String>]`: 
    - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
  - `[Description <String>]`: A description for the resource.
  - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
  - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment.
  - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
  - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
  - `[ResourceType <String>]`: The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
  - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.

ACCESSPACKAGERESOURCESCOPES <IMicrosoftGraphAccessPackageResourceScope[]>: .
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
      - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
      - `[CreatedBy <String>]`: The display name of the user that created this object.
      - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Description <String>]`: The description of this accessPackageResourceEnvironment object.
      - `[DisplayName <String>]`: The display name of this object.
      - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.
      - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
      - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system such as SharePointOnline. Supports $filter.
    - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[Description <String>]`: A description for the resource role.
      - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
      - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
    - `[AddedBy <String>]`: Read-only.
    - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: 
      - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AttributeName <String>]`: 
      - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
    - `[Description <String>]`: A description for the resource.
    - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
    - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment.
    - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
    - `[ResourceType <String>]`: The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
    - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.
  - `[Description <String>]`: The description of the scope.
  - `[DisplayName <String>]`: The display name of the scope.
  - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
  - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
  - `[OriginSystem <String>]`: The origin system for the scope.
  - `[RoleOriginId <String>]`: The origin system for the role, if different.
  - `[Url <String>]`: A resource locator for the scope.

ACCESSPACKAGES <IMicrosoftGraphAccessPackage[]>: The access packages in this catalog. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
    - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: Read-only.
            - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
            - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
            - `[CreatedBy <String>]`: The display name of the user that created this object.
            - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Description <String>]`: The description of this accessPackageResourceEnvironment object.
            - `[DisplayName <String>]`: The display name of this object.
            - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.
            - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
            - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
            - `[OriginSystem <String>]`: The type of the resource in the origin system such as SharePointOnline. Supports $filter.
          - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable.
          - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
            - `[Id <String>]`: Read-only.
            - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
            - `[Description <String>]`: The description of the scope.
            - `[DisplayName <String>]`: The display name of the scope.
            - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
            - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
            - `[OriginSystem <String>]`: The origin system for the scope.
            - `[RoleOriginId <String>]`: The origin system for the role, if different.
            - `[Url <String>]`: A resource locator for the scope.
          - `[AddedBy <String>]`: Read-only.
          - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
          - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: 
            - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[AttributeName <String>]`: 
            - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: 
          - `[Description <String>]`: A description for the resource.
          - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
          - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment.
          - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
          - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
          - `[ResourceType <String>]`: The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
          - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.
        - `[Description <String>]`: A description for the resource role.
        - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
        - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
        - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
      - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Nullable.
      - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: The access packages in this catalog. Read-only. Nullable.
      - `[CatalogStatus <String>]`: Has the value Published if the access packages are available for management.
      - `[CatalogType <String>]`: One of UserManaged or ServiceDefault.
      - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Description <String>]`: The description of the access package catalog.
      - `[DisplayName <String>]`: The display name of the access package catalog.
      - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
      - `[ModifiedBy <String>]`: The UPN of the user who last modified this resource. Read-only.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[AccessPackageId <String>]`: ID of the access package.
    - `[AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>]`: assignmentReviewSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DurationInDays <Int32?>]`: The number of days to allow input from reviewers.
      - `[IsEnabled <Boolean?>]`: If true, access reviews are required for assignments from this policy.
      - `[RecurrenceType <String>]`: The interval for recurrence, such as monthly or quarterly.
      - `[ReviewerType <String>]`: Who should be asked to do the review, either Self or Reviewers.
      - `[Reviewers <IMicrosoftGraphUserSet[]>]`: If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers.
        - `[IsBackup <Boolean?>]`: For a user in an approval stage, this property indicates whether the user is a backup fallback approver.
      - `[StartDateTime <DateTime?>]`: When the first review should start.
    - `[CanExtend <Boolean?>]`: Indicates whether a user can extend the access package assignment duration after approval.
    - `[CreatedBy <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Description <String>]`: The description of the policy.
    - `[DisplayName <String>]`: The display name of the policy.
    - `[DurationInDays <Int32?>]`: The number of days in which assignments from this policy last until they are expired.
    - `[ExpirationDateTime <DateTime?>]`: The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[ModifiedBy <String>]`: Read-only.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Questions <IMicrosoftGraphAccessPackageQuestion[]>]`: Questions that are posed to the  requestor.
      - `[Id <String>]`: ID of the question.
      - `[IsRequired <Boolean?>]`: Whether the requestor is required to supply an answer or not.
      - `[Sequence <Int32?>]`: Relative position of this question when displaying a list of questions to the requestor.
      - `[Text <IMicrosoftGraphAccessPackageLocalizedContent>]`: accessPackageLocalizedContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultText <String>]`: The fallback string, which is used when a requested localization is not available. Required.
        - `[LocalizedTexts <IMicrosoftGraphAccessPackageLocalizedText[]>]`: Content represented in a format for a specific locale.
          - `[LanguageCode <String>]`: The ISO code for the intended language. Required.
          - `[Text <String>]`: The text in the specific language. Required.
    - `[RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]`: approvalSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ApprovalMode <String>]`: One of NoApproval, SingleStage or Serial. The NoApproval is used when isApprovalRequired is false.
      - `[ApprovalStages <IMicrosoftGraphApprovalStage1[]>]`: If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.
        - `[ApprovalStageTimeOutInDays <Int32?>]`: The number of days that a request can be pending a response before it is automatically denied.
        - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.
        - `[EscalationTimeInMinutes <Int32?>]`: If escalation is required, the time a request can be pending a response from a primary approver.
        - `[IsApproverJustificationRequired <Boolean?>]`: Indicates whether the approver is required to provide a justification for approving a request.
        - `[IsEscalationEnabled <Boolean?>]`: If true, then one or more escalation approvers are configured in this approval stage.
        - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.
      - `[IsApprovalRequired <Boolean?>]`: If false, then approval is not required for requests in this policy.
      - `[IsApprovalRequiredForExtension <Boolean?>]`: If false, then approval is not required for a user who already has an assignment to extend their assignment.
      - `[IsRequestorJustificationRequired <Boolean?>]`: Indicates whether the requestor is required to supply a justification in their request.
    - `[RequestorSettings <IMicrosoftGraphRequestorSettings>]`: requestorSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AcceptRequests <Boolean?>]`: Indicates whether new requests are accepted on this policy.
      - `[AllowedRequestors <IMicrosoftGraphUserSet[]>]`: The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers.
      - `[ScopeType <String>]`: Who can request. One of NoSubjects, SpecificDirectorySubjects, SpecificConnectedOrganizationSubjects, AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects or AllExternalSubjects.
  - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
  - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: Nullable.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
    - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
    - `[CreatedBy <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[ModifiedBy <String>]`: Read-only.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CatalogId <String>]`: ID of the access package catalog referencing this access package. Read-only.
  - `[CreatedBy <String>]`: UPN of the user or identity of the subject who created this resource. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package.
  - `[DisplayName <String>]`: The display name of the access package.
  - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
  - `[IsRoleScopesVisible <Boolean?>]`: Indicates whether role scopes are visible.
  - `[ModifiedBy <String>]`: The UPN of the user who last modified this resource. Read-only.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

BODYPARAMETER <IMicrosoftGraphAccessPackageCatalog>: accessPackageCatalog
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceEnvironment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Required.
        - `[ConnectionInfo <IMicrosoftGraphConnectionInfo>]`: connectionInfo
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Url <String>]`: The endpoint that is used by Entitlement Management to communicate with the access package resource.
        - `[CreatedBy <String>]`: The display name of the user that created this object.
        - `[CreatedDateTime <DateTime?>]`: The date and time that this object was created. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Description <String>]`: The description of this accessPackageResourceEnvironment object.
        - `[DisplayName <String>]`: The display name of this object.
        - `[IsDefaultEnvironment <Boolean?>]`: Determines whether this is default environment or not. It is set to true for all static origin systems, such as Azure AD groups and Azure AD Applications.
        - `[ModifiedBy <String>]`: The display name of the entity that last modified this object.
        - `[ModifiedDateTime <DateTime?>]`: The date and time that this object was last modified. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[OriginId <String>]`: The unique identifier of this environment in the origin system.
        - `[OriginSystem <String>]`: The type of the resource in the origin system such as SharePointOnline. Supports $filter.
      - `[AccessPackageResourceRoles <IMicrosoftGraphAccessPackageResourceRole[]>]`: Read-only. Nullable.
      - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: Read-only. Nullable.
        - `[Id <String>]`: Read-only.
        - `[AccessPackageResource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
        - `[Description <String>]`: The description of the scope.
        - `[DisplayName <String>]`: The display name of the scope.
        - `[IsRootScope <Boolean?>]`: True if the scopes are arranged in a hierarchy and this is the top or root scope of the resource.
        - `[OriginId <String>]`: The unique identifier for the scope in the resource as defined in the origin system.
        - `[OriginSystem <String>]`: The origin system for the scope.
        - `[RoleOriginId <String>]`: The origin system for the role, if different.
        - `[Url <String>]`: A resource locator for the scope.
      - `[AddedBy <String>]`: Read-only.
      - `[AddedOn <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Attributes <IMicrosoftGraphAccessPackageResourceAttribute[]>]`: 
        - `[AttributeDestination <IMicrosoftGraphAccessPackageResourceAttributeDestination>]`: accessPackageResourceAttributeDestination
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AttributeName <String>]`: 
        - `[AttributeSource <IMicrosoftGraphAccessPackageResourceAttributeSource>]`: accessPackageResourceAttributeSource
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
      - `[Description <String>]`: A description for the resource.
      - `[DisplayName <String>]`: The display name of the resource, such as the application name, group name or site name.
      - `[IsPendingOnboarding <Boolean?>]`: True if the resource is not yet available for assignment.
      - `[OriginId <String>]`: The unique identifier of the resource in the origin system. In the case of an Azure AD group, this is the identifier of the group.
      - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
      - `[ResourceType <String>]`: The type of the resource, such as Application if it is an Azure AD connected application, or SharePoint Online Site for a SharePoint Online site.
      - `[Url <String>]`: A unique resource locator for the resource, such as the URL for signing a user into an application.
    - `[Description <String>]`: A description for the resource role.
    - `[DisplayName <String>]`: The display name of the resource role such as the role defined by the application.
    - `[OriginId <String>]`: The unique identifier of the resource role in the origin system.
    - `[OriginSystem <String>]`: The type of the resource in the origin system, such as SharePointOnline, AadApplication or AadGroup.
  - `[AccessPackageResourceScopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
  - `[AccessPackageResources <IMicrosoftGraphAccessPackageResource[]>]`: Read-only. Nullable.
  - `[AccessPackages <IMicrosoftGraphAccessPackage[]>]`: The access packages in this catalog. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AccessPackageAssignmentPolicies <IMicrosoftGraphAccessPackageAssignmentPolicy[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AccessPackage <IMicrosoftGraphAccessPackage>]`: accessPackage
      - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
      - `[AccessPackageId <String>]`: ID of the access package.
      - `[AccessReviewSettings <IMicrosoftGraphAssignmentReviewSettings>]`: assignmentReviewSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DurationInDays <Int32?>]`: The number of days to allow input from reviewers.
        - `[IsEnabled <Boolean?>]`: If true, access reviews are required for assignments from this policy.
        - `[RecurrenceType <String>]`: The interval for recurrence, such as monthly or quarterly.
        - `[ReviewerType <String>]`: Who should be asked to do the review, either Self or Reviewers.
        - `[Reviewers <IMicrosoftGraphUserSet[]>]`: If the reviewerType is Reviewers, this collection specifies the users who will be reviewers, either by ID or as members of a group, using a collection of singleUser and groupMembers.
          - `[IsBackup <Boolean?>]`: For a user in an approval stage, this property indicates whether the user is a backup fallback approver.
        - `[StartDateTime <DateTime?>]`: When the first review should start.
      - `[CanExtend <Boolean?>]`: Indicates whether a user can extend the access package assignment duration after approval.
      - `[CreatedBy <String>]`: Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Description <String>]`: The description of the policy.
      - `[DisplayName <String>]`: The display name of the policy.
      - `[DurationInDays <Int32?>]`: The number of days in which assignments from this policy last until they are expired.
      - `[ExpirationDateTime <DateTime?>]`: The expiration date for assignments created in this policy. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ModifiedBy <String>]`: Read-only.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Questions <IMicrosoftGraphAccessPackageQuestion[]>]`: Questions that are posed to the  requestor.
        - `[Id <String>]`: ID of the question.
        - `[IsRequired <Boolean?>]`: Whether the requestor is required to supply an answer or not.
        - `[Sequence <Int32?>]`: Relative position of this question when displaying a list of questions to the requestor.
        - `[Text <IMicrosoftGraphAccessPackageLocalizedContent>]`: accessPackageLocalizedContent
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DefaultText <String>]`: The fallback string, which is used when a requested localization is not available. Required.
          - `[LocalizedTexts <IMicrosoftGraphAccessPackageLocalizedText[]>]`: Content represented in a format for a specific locale.
            - `[LanguageCode <String>]`: The ISO code for the intended language. Required.
            - `[Text <String>]`: The text in the specific language. Required.
      - `[RequestApprovalSettings <IMicrosoftGraphApprovalSettings>]`: approvalSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ApprovalMode <String>]`: One of NoApproval, SingleStage or Serial. The NoApproval is used when isApprovalRequired is false.
        - `[ApprovalStages <IMicrosoftGraphApprovalStage1[]>]`: If approval is required, the one or two elements of this collection define each of the stages of approval. An empty array if no approval is required.
          - `[ApprovalStageTimeOutInDays <Int32?>]`: The number of days that a request can be pending a response before it is automatically denied.
          - `[EscalationApprovers <IMicrosoftGraphUserSet[]>]`: If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests. This can be a collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.
          - `[EscalationTimeInMinutes <Int32?>]`: If escalation is required, the time a request can be pending a response from a primary approver.
          - `[IsApproverJustificationRequired <Boolean?>]`: Indicates whether the approver is required to provide a justification for approving a request.
          - `[IsEscalationEnabled <Boolean?>]`: If true, then one or more escalation approvers are configured in this approval stage.
          - `[PrimaryApprovers <IMicrosoftGraphUserSet[]>]`: The users who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors and externalSponsors.
        - `[IsApprovalRequired <Boolean?>]`: If false, then approval is not required for requests in this policy.
        - `[IsApprovalRequiredForExtension <Boolean?>]`: If false, then approval is not required for a user who already has an assignment to extend their assignment.
        - `[IsRequestorJustificationRequired <Boolean?>]`: Indicates whether the requestor is required to supply a justification in their request.
      - `[RequestorSettings <IMicrosoftGraphRequestorSettings>]`: requestorSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AcceptRequests <Boolean?>]`: Indicates whether new requests are accepted on this policy.
        - `[AllowedRequestors <IMicrosoftGraphUserSet[]>]`: The users who are allowed to request on this policy, which can be singleUser, groupMembers, and connectedOrganizationMembers.
        - `[ScopeType <String>]`: Who can request. One of NoSubjects, SpecificDirectorySubjects, SpecificConnectedOrganizationSubjects, AllConfiguredConnectedOrganizationSubjects, AllExistingConnectedOrganizationSubjects, AllExistingDirectoryMemberUsers, AllExistingDirectorySubjects or AllExternalSubjects.
    - `[AccessPackageCatalog <IMicrosoftGraphAccessPackageCatalog>]`: accessPackageCatalog
    - `[AccessPackageResourceRoleScopes <IMicrosoftGraphAccessPackageResourceRoleScope[]>]`: Nullable.
      - `[Id <String>]`: Read-only.
      - `[AccessPackageResourceRole <IMicrosoftGraphAccessPackageResourceRole>]`: accessPackageResourceRole
      - `[AccessPackageResourceScope <IMicrosoftGraphAccessPackageResourceScope>]`: accessPackageResourceScope
      - `[CreatedBy <String>]`: Read-only.
      - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ModifiedBy <String>]`: Read-only.
      - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[CatalogId <String>]`: ID of the access package catalog referencing this access package. Read-only.
    - `[CreatedBy <String>]`: UPN of the user or identity of the subject who created this resource. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Description <String>]`: The description of the access package.
    - `[DisplayName <String>]`: The display name of the access package.
    - `[IsHidden <Boolean?>]`: Whether the access package is hidden from the requestor.
    - `[IsRoleScopesVisible <Boolean?>]`: Indicates whether role scopes are visible.
    - `[ModifiedBy <String>]`: The UPN of the user who last modified this resource. Read-only.
    - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[CatalogStatus <String>]`: Has the value Published if the access packages are available for management.
  - `[CatalogType <String>]`: One of UserManaged or ServiceDefault.
  - `[CreatedBy <String>]`: UPN of the user who created this resource. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Description <String>]`: The description of the access package catalog.
  - `[DisplayName <String>]`: The display name of the access package catalog.
  - `[IsExternallyVisible <Boolean?>]`: Whether the access packages in this catalog can be requested by users outside of the tenant.
  - `[ModifiedBy <String>]`: The UPN of the user who last modified this resource. Read-only.
  - `[ModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

## RELATED LINKS

## RELATED LINKS
