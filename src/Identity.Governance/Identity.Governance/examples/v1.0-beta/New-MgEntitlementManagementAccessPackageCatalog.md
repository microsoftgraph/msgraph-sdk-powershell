### Example 1: Using the New-MgBetaEntitlementManagementAccessPackageCatalog Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	DisplayName = "sales"
	Description = "for employees working with sales and outside sales partners"
	IsExternallyVisible = $true
}
New-MgBetaEntitlementManagementAccessPackageCatalog -BodyParameter $params
```
This example shows how to use the New-MgBetaEntitlementManagementAccessPackageCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
