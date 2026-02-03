### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Contoso organization"
	description = "Multitenant organization between Contoso, Fabrikam, and Woodgrove Bank"
}

Update-MgTenantRelationshipMultiTenantOrganization -BodyParameter $params

```
This example shows how to use the Update-MgTenantRelationshipMultiTenantOrganization Cmdlet.

