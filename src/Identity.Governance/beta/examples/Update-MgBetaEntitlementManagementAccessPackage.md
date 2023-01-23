### Example 1: Using the Update-MgBetaEntitlementManagementAccessPackage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "Access Package New Name"
}
Update-MgBetaEntitlementManagementAccessPackage -AccessPackageId $accessPackageId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEntitlementManagementAccessPackage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
