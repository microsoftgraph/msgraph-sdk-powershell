### Example 1: Using the Update-MgEntitlementManagementCatalog Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Catalog One"
}
Update-MgEntitlementManagementCatalog -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params
```
This example shows how to use the Update-MgEntitlementManagementCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
