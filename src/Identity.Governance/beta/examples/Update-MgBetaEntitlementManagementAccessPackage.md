### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "Access Package New Name"
}

Update-MgBetaEntitlementManagementAccessPackage -AccessPackageId $accessPackageId -BodyParameter $params

```
This example shows how to use the Update-MgBetaEntitlementManagementAccessPackage Cmdlet.

