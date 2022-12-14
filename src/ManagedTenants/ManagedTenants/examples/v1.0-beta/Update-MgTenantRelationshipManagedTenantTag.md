### Example 1: Using the Update-MgBetaTenantRelationshipManagedTenantTag Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.ManagedTenants
$params = @{
	DisplayName = "Onboarding"
	Description = "Tenants that we are currently onboarding"
}
Update-MgBetaTenantRelationshipManagedTenantTag -TenantTagId $tenantTagId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTenantRelationshipManagedTenantTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
