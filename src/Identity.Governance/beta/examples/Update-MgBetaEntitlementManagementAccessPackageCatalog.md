### Example 1: Using the Update-MgBetaEntitlementManagementAccessPackageCatalog Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "Catalog One"
}
Update-MgBetaEntitlementManagementAccessPackageCatalog -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEntitlementManagementAccessPackageCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
