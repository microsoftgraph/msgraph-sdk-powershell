### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	catalogId = "3301434b-99bd-46be-923b-d762c30c8e8b"
}

Move-MgBetaEntitlementManagementAccessPackageToCatalog -AccessPackageId $accessPackageId -BodyParameter $params

```
This example shows how to use the Move-MgBetaEntitlementManagementAccessPackageToCatalog Cmdlet.

