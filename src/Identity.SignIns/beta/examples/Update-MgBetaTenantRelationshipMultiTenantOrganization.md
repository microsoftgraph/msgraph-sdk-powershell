### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Contoso organization"
	description = "Multi-tenant organization between Contoso, Fabrikam, and Woodgrove Bank"
}

Update-MgBetaTenantRelationshipMultiTenantOrganization -BodyParameter $params

```
This example shows how to use the Update-MgBetaTenantRelationshipMultiTenantOrganization Cmdlet.

