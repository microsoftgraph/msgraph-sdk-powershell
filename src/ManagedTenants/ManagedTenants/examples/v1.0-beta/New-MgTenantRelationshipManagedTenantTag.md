### Example 1: Using the New-MgBetaTenantRelationshipManagedTenantTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.ManagedTenants
$params = @{
	DisplayName = "Support"
	Description = "Tenants that have purchased extended support"
}
New-MgBetaTenantRelationshipManagedTenantTag -BodyParameter $params
```
This example shows how to use the New-MgBetaTenantRelationshipManagedTenantTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
