### Example 1: List all resources in a catalog

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementCatalogResource -AccessPackageCatalogId $accessPackageCatalogId -ExpandProperty "scopes" 

```
This example will list all resources in a catalog

### Example 2: Retrieve the roles and scopes of a single resource in a catalog

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementCatalogResource -AccessPackageCatalogId $accessPackageCatalogId -ExpandProperty "roles,scopes" -Filter "id eq '{resourceId}'" 

```
This example will retrieve the roles and scopes of a single resource in a catalog

### Example 3: Retrieve the roles and scopes of a single resource in a catalog by origin ID

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgEntitlementManagementCatalogResource -AccessPackageCatalogId $accessPackageCatalogId -ExpandProperty "roles,scopes" -Filter "originId eq '0282e19d-bf41-435d-92a4-99bab93af305'" 

```
This example will retrieve the roles and scopes of a single resource in a catalog by origin id

