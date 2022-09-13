###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Catalog One"
}
Update-MgEntitlementManagementCatalog -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params
```
