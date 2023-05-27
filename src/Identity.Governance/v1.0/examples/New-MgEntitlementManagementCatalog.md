### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "sales"
	description = "for employees working with sales and outside sales partners"
	state = "published"
	isExternallyVisible = $true
}

New-MgEntitlementManagementCatalog -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementCatalog Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

