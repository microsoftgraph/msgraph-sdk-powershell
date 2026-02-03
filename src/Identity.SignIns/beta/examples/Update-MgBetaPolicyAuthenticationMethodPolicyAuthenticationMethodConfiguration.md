### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalAuthenticationMethodConfiguration"
	includeTargets = @(
		@{
			targetType = "group"
			id = "b183b746-e7db-4fa2-bafc-69ecf18850dd"
			isRegistrationRequired = $false
		}
	)
	state = "enabled"
}

Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration -AuthenticationMethodConfigurationId $authenticationMethodConfigurationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration Cmdlet.

