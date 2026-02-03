### Example 1: Block outbound B2B collaboration for a group of users

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	b2bCollaborationOutbound = @{
		usersAndGroups = @{
			accessType = "blocked"
			targets = @(
				@{
					target = "0be493dc-cb56-4a53-936f-9cf64410b8b0"
					targetType = "group"
				}
			)
		}
		applications = @{
			accessType = "blocked"
			targets = @(
				@{
					target = "AllApplications"
					targetType = "application"
				}
			)
		}
	}
}

Update-MgBetaPolicyCrossTenantAccessPolicyDefault -BodyParameter $params

```
This example will block outbound b2b collaboration for a group of users

### Example 2: Update default invitation redemption configuration

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	invitationRedemptionIdentityProviderConfiguration = @{
		primaryIdentityProviderPrecedenceOrder = @(
		"externalFederation"
	"azureActiveDirectory"
"socialIdentityProviders"
)
fallbackIdentityProvider = "defaultConfiguredIdp"
}
}

Update-MgBetaPolicyCrossTenantAccessPolicyDefault -BodyParameter $params

```
This example will update default invitation redemption configuration

### Example 3: Disallow Microsoft accounts as an option for redeeming B2B invitations

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	invitationRedemptionIdentityProviderConfiguration = @{
		primaryIdentityProviderPrecedenceOrder = @(
		"externalFederation"
	"azureActiveDirectory"
"socialIdentityProviders"
)
fallbackIdentityProvider = "emailOneTimePasscode"
}
}

Update-MgBetaPolicyCrossTenantAccessPolicyDefault -BodyParameter $params

```
This example will disallow microsoft accounts as an option for redeeming b2b invitations

