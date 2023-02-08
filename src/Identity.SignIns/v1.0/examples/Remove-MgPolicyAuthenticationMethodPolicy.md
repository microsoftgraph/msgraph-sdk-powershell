### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.context" = "https://graph.microsoft.com/v1.0/$metadata#authenticationMethodsPolicy"
	RegistrationEnforcement = @{
		AuthenticationMethodsRegistrationCampaign = @{
			SnoozeDurationInDays = 1
			State = "enabled"
			ExcludeTargets = @(
			)
			IncludeTargets = @(
				@{
					Id = "3ee3a9de-0a86-4e12-a287-9769accf1ba2"
					TargetType = "group"
					TargetedAuthenticationMethod = "microsoftAuthenticator"
				}
			)
		}
	}
	AuthenticationMethodConfigurations = @(
		@{
			"@odata.type" = "#microsoft.graph.fido2AuthenticationMethodConfiguration"
			Id = "Fido2"
			State = "disabled"
			IsSelfServiceRegistrationAllowed = $false
			IsAttestationEnforced = $false
		}
	)
}

Update-MgPolicyAuthenticationMethodPolicy -BodyParameter $params
```
This example shows how to use the Remove-MgPolicyAuthenticationMethodPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

