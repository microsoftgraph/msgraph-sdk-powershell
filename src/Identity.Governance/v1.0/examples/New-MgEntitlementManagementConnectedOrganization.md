### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Connected organization name"
	description = "Connected organization description"
	identitySources = @(
		@{
			"@odata.type" = "#microsoft.graph.domainIdentitySource"
			domainName = "example.com"
			displayName = "example.com"
		}
	)
	state = "proposed"
}

New-MgEntitlementManagementConnectedOrganization -BodyParameter $params

```
This example shows how to use the New-MgEntitlementManagementConnectedOrganization Cmdlet.

