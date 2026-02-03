### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.ManagedTenants

$params = @{
	displayName = "Support"
	description = "Tenants that have purchased extended support"
}

New-MgBetaTenantRelationshipManagedTenantTag -BodyParameter $params

```
This example shows how to use the New-MgBetaTenantRelationshipManagedTenantTag Cmdlet.

