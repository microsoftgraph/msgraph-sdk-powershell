### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	tenantIds = @(
	"String"
)
}

Set-MgBetaTenantRelationshipManagedTenantTag -TenantTagId $tenantTagId -BodyParameter $params

```
This example shows how to use the Set-MgBetaTenantRelationshipManagedTenantTag Cmdlet.

