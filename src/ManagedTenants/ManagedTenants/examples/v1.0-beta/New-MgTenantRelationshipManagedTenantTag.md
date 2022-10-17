### Example 1: Using the New-MgTenantRelationshipManagedTenantTag Cmdlet
```powershell
Import-Module Microsoft.Graph.ManagedTenants
$params = @{
	DisplayName = "Support"
	Description = "Tenants that have purchased extended support"
}
New-MgTenantRelationshipManagedTenantTag -BodyParameter $params
```
This example shows how to use the New-MgTenantRelationshipManagedTenantTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
