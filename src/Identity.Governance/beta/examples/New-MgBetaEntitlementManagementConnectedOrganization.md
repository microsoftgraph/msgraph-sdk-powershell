### Example 1: Create a connected organization

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

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

New-MgBetaEntitlementManagementConnectedOrganization -BodyParameter $params

```
This example will create a connected organization

### Example 2: Create a connected organization with an identitySource based on a tenant ID

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "Connected organization name"
	description = "Connected organization description"
	identitySources = @(
		@{
			"@odata.type" = "#microsoft.graph.azureActiveDirectoryTenant"
			displayName = "Contoso"
			tenantId = "aaaabbbb-0000-cccc-1111-dddd2222eeee"
		}
	)
	state = "proposed"
}

New-MgBetaEntitlementManagementConnectedOrganization -BodyParameter $params

```
This example will create a connected organization with an identitysource based on a tenant id

