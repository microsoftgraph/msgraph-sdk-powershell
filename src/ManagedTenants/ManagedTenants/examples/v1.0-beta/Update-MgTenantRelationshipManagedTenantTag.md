### Example 1: Using the Update-MgTenantRelationshipManagedTenantTag Cmdlet
```powershell
Import-Module Microsoft.Graph.ManagedTenants
$params = @{
	DisplayName = "Onboarding"
	Description = "Tenants that we are currently onboarding"
}
Update-MgTenantRelationshipManagedTenantTag -TenantTagId $tenantTagId -BodyParameter $params
```
This example shows how to use the Update-MgTenantRelationshipManagedTenantTag Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
