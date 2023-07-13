### Example 1: List all applications specific to the tenant

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAppCatalogTeamApp -Filter "distributionMethod eq 'organization'"
```
This example shows how to use the Get-MgAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List applications with a given ID

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAppCatalogTeamApp -Filter "id eq 'b1c5353a-7aca-41b3-830f-27d5218fe0e5'"
```
This example shows how to use the Get-MgAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Find application based on the Teams app manifest ID

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAppCatalogTeamApp -Filter "externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'"
```
This example shows how to use the Get-MgAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: List applications with a given ID, and return the submission review state

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAppCatalogTeamApp -Filter "id eq '876df28f-2e78-423b-94a5-44181bd0e225'" -ExpandProperty "appDefinitions"
```
This example shows how to use the Get-MgAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: List the details of only those apps in the catalog that contain a bot

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAppCatalogTeamApp -ExpandProperty "appDefinitions(`$expand=bot)" -Filter "appDefinitions/any(a:a/bot ne null)"
```
This example shows how to use the Get-MgAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 7: List applications with a given ID and return only the resource specific permissions required by the app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgAppCatalogTeamApp -Filter "id eq 'a5228c26-a9ae-4702-90e0-79a5246d2f7d'" -ExpandProperty "appDefinitions(`$select=id,authorization)"
```
This example shows how to use the Get-MgAppCatalogTeamApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

