### Example 1: Using the New-MgEntitlementManagementCatalog Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "sales"
	Description = "for employees working with sales and outside sales partners"
	State = "published"
	IsExternallyVisible = $true
}
New-MgEntitlementManagementCatalog -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
