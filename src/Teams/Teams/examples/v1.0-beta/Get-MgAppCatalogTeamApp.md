### Example 1: Using the Get-MgBetaAppCatalogTeamApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaAppCatalogTeamApp -Filter "externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
This example shows how to use the Get-MgBetaAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaAppCatalogTeamApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaAppCatalogTeamApp -Filter "id eq 'b1c5353a-7aca-41b3-830f-27d5218fe0e5'" 
```
This example shows how to use the Get-MgBetaAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaAppCatalogTeamApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaAppCatalogTeamApp -ExpandProperty "appDefinitions(`$select=id,displayName,allowedInstallationScopes)" -Filter "appDefinitions/any(a:a/allowedInstallationScopes has 'personal')" 
```
This example shows how to use the Get-MgBetaAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaAppCatalogTeamApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaAppCatalogTeamApp -ExpandProperty "appDefinitions(`$expand=bot)" -Filter "appDefinitions/any(a:a/bot ne null)" 
```
This example shows how to use the Get-MgBetaAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgBetaAppCatalogTeamApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaAppCatalogTeamApp -Filter "id eq '876df28f-2e78-423b-94a5-44181bd0e225'" -ExpandProperty "appDefinitions" 
```
This example shows how to use the Get-MgBetaAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Get-MgBetaAppCatalogTeamApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaAppCatalogTeamApp -Filter "distributionMethod eq 'organization'" 
```
This example shows how to use the Get-MgBetaAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
