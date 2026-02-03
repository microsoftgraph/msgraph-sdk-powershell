### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.ManagedTenants

$params = @{
	displayName = "Onboarding"
	description = "Tenants that we are currently onboarding"
}

Update-MgBetaTenantRelationshipManagedTenantTag -TenantTagId $tenantTagId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTenantRelationshipManagedTenantTag Cmdlet.

