###Example 1
```
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
