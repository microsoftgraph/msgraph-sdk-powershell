---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.governance/get-mgbetaentitlementmanagementaccesspackagecatalogaccesspackageresource
schema: 2.0.0
---

# Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource

## SYNOPSIS
Retrieve a list of accessPackageResource objects in an accessPackageCatalog.
To request to add or remove an accessPackageResource, use create accessPackageResourceRequest.
This API is available in the following national cloud deployments.

## SYNTAX

```
Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource -AccessPackageCatalogId <String>
 [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Retrieve a list of accessPackageResource objects in an accessPackageCatalog.
To request to add or remove an accessPackageResource, use create accessPackageResourceRequest.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' | Format-List
```

AccessPackageResourceEnvironment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceEnvironment
AccessPackageResourceRoles       :
AccessPackageResourceScopes      :
AddedBy                          : admin@M365x814237.onmicrosoft.com
AddedOn                          : 10/19/2021 2:50:24 PM
Attributes                       : {}
Description                      : Marketing resources
DisplayName                      : Marketing resources
Id                               : 36d8d18f-b081-4867-acf5-4a8b893761e8
IsPendingOnboarding              : False
OriginId                         : b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
OriginSystem                     : AadGroup
ResourceType                     : Security Group
Url                              : https://account.activedirectory.windowsazure.com/r?tenantId=c265ddcc-4694-4bb0-b771-4829ca21177d#/manageMembership?objectType=Group&objectId=b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
AdditionalProperties             : {}

AccessPackageResourceEnvironment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceEnvironment
AccessPackageResourceRoles       :
AccessPackageResourceScopes      :
AddedBy                          : admin@M365x814237.onmicrosoft.com
AddedOn                          : 10/13/2021 8:51:24 AM
Attributes                       : {}
Description                      : Marketing group2
DisplayName                      : Marketing resources2
Id                               : 99cbe4a3-d7d2-4f19-90af-cc7c9dccd7f8
IsPendingOnboarding              : False
OriginId                         : c41e321d-2907-4183-8224-b4cec9c9381b
OriginSystem                     : AadGroup
ResourceType                     : Security Group
Url                              : https://account.activedirectory.windowsazure.com/r?tenantId=c265ddcc-4694-4bb0-b771-4829ca21177d#/manageMembership?objectType=Group&objectId=c41e321d-2907-4183-8224-b4cec9c9381b
AdditionalProperties             : {}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Connect-MgBetaGraph -Scopes 'EntitlementManagement.ReadWrite.All'
Get-MgBetaEntitlementManagementAccessPackageCatalogAccessPackageResource -AccessPackageCatalogId '54152ecb-c65d-47f2-8a4d-ba2732de0a7b' -Filter "DisplayName eq 'Marketing resources'" | Format-List
```

AccessPackageResourceEnvironment : Microsoft.Graph.PowerShell.Models.MicrosoftGraphAccessPackageResourceEnvironment
AccessPackageResourceRoles       :
AccessPackageResourceScopes      :
AddedBy                          : admin@M365x814237.onmicrosoft.com
AddedOn                          : 10/19/2021 2:50:24 PM
Attributes                       : {}
Description                      : Marketing resources
DisplayName                      : Marketing resources
Id                               : 36d8d18f-b081-4867-acf5-4a8b893761e8
IsPendingOnboarding              : False
OriginId                         : b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
OriginSystem                     : AadGroup
ResourceType                     : Security Group
Url                              : https://account.activedirectory.windowsazure.com/r?tenantId=c265ddcc-4694-4bb0-b771-4829ca21177d#/manageMembership?objectType=Group&objectId=b5cd9d19-91c0-4622-93e2-537ad8a0b3ad
AdditionalProperties             : {}

## PARAMETERS

### -AccessPackageCatalogId
The unique identifier of accessPackageCatalog

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -All
List all pages.

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

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAccessPackageResource

## NOTES

ALIASES

## RELATED LINKS

