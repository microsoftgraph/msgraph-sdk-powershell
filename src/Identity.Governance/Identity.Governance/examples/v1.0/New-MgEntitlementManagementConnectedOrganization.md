### Example 1: Using the New-MgEntitlementManagementConnectedOrganization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Connected organization name"
	Description = "Connected organization description"
	IdentitySources = @(
		@{
			"@odata.type" = "#microsoft.graph.domainIdentitySource"
			DomainName = "example.com"
			DisplayName = "example.com"
		}
	)
	State = "proposed"
}
New-MgEntitlementManagementConnectedOrganization -BodyParameter $params
```
This example shows how to use the New-MgEntitlementManagementConnectedOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
