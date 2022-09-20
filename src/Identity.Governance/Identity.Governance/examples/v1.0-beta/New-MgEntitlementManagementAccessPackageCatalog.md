### Example 1: Using the New-MgEntitlementManagementAccessPackageCatalog Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "sales"
	Description = "for employees working with sales and outside sales partners"
	IsExternallyVisible = $true
}
New-MgEntitlementManagementAccessPackageCatalog -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementAccessPackageCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
