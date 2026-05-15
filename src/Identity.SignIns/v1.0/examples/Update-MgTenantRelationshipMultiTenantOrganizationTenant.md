### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	role = "owner"
}

Update-MgTenantRelationshipMultiTenantOrganizationTenant -MultiTenantOrganizationMemberId $multiTenantOrganizationMemberId -BodyParameter $params

```
This example shows how to use the Update-MgTenantRelationshipMultiTenantOrganizationTenant Cmdlet.

