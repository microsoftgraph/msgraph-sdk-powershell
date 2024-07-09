### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	tenantIds = @(
	"String"
)
}

Invoke-MgBetaTagTenantRelationshipManagedTenantTagUnassign -TenantTagId $tenantTagId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaTagTenantRelationshipManagedTenantTagUnassign Cmdlet.

