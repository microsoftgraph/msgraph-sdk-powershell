### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "Catalog One"
}

Update-MgBetaEntitlementManagementAccessPackageCatalog -AccessPackageCatalogId $accessPackageCatalogId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEntitlementManagementAccessPackageCatalog Cmdlet.

