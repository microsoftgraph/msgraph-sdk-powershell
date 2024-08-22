### Example 1: List all applications specific to the tenant

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -Filter "distributionMethod eq 'organization'" 

```
This example will list all applications specific to the tenant

### Example 2: List applications with a given ID

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -Filter "id eq 'b1c5353a-7aca-41b3-830f-27d5218fe0e5'" 

```
This example will list applications with a given id

### Example 3: Find application based on the Teams app manifest ID

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -Filter "externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 

```
This example will find application based on the teams app manifest id

### Example 4: List applications with a given ID, and return the submission review state

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -Filter "id eq '876df28f-2e78-423b-94a5-44181bd0e225'" -ExpandProperty "appDefinitions" 

```
This example will list applications with a given id, and return the submission review state

### Example 5: List the details of only those apps in the catalog that contain a bot

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -ExpandProperty "appDefinitions(`$expand=bot)" -Filter "appDefinitions/any(a:a/bot ne null)" 

```
This example will list the details of only those apps in the catalog that contain a bot

### Example 6: List the details of apps filtered by app installation scope

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -ExpandProperty "appDefinitions(`$select=id,displayName,allowedInstallationScopes)" -Filter "appDefinitions/any(a:a/allowedInstallationScopes has 'personal')" 

```
This example will list the details of apps filtered by app installation scope

### Example 7: List applications with a given ID and return only the resource specific permissions required by the app

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -Filter "id eq 'a5228c26-a9ae-4702-90e0-79a5246d2f7d'" -ExpandProperty "appDefinitions(`$select=id,authorization)" 

```
This example will list applications with a given id and return only the resource specific permissions required by the app

### Example 8: List details of apps in the app catalog that contain dashboard cards

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaAppCatalogTeamApp -ExpandProperty "appDefinitions(`$expand=dashboardCards)" -Filter "appDefinitions/any(a:a/dashboardCards/`$count ne 0)" 

```
This example will list details of apps in the app catalog that contain dashboard cards

