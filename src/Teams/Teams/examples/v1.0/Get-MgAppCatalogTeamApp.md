### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgAppCatalogTeamApp -Filter "externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgAppCatalogTeamApp -Filter "id eq 'b1c5353a-7aca-41b3-830f-27d5218fe0e5'" 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgAppCatalogTeamApp -ExpandProperty "appDefinitions(`$expand=bot)" -Filter "appDefinitions/any(a:a/bot ne null)" 
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgAppCatalogTeamApp -Filter "id eq '876df28f-2e78-423b-94a5-44181bd0e225'" -ExpandProperty "appDefinitions" 
```
### Example 5
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgAppCatalogTeamApp -Filter "distributionMethod eq 'organization'" 
```
