### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Catalog One"
}

Update-MgEntitlementManagementCatalog -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params
```
This example shows how to use the Remove-MgEntitlementManagementCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

