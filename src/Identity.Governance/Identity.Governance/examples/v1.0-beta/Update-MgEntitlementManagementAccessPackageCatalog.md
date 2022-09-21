### Example 1: Using the Update-MgEntitlementManagementAccessPackageCatalog Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Catalog One"
}
Update-MgEntitlementManagementAccessPackageCatalog -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params
```
This example shows how to use the Update-MgEntitlementManagementAccessPackageCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
