### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onTokenIssuanceStartCustomExtension"
	displayName = "onTokenIssuanceStartCustomExtension"
	description = "Fetch additional claims from custom user store"
	endpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.httpRequestEndpoint"
		targetUrl = "https://authenticationeventsAPI.contoso.com"
	}
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		resourceId = "api://authenticationeventsAPI.contoso.com/a13d0fc1-04ab-4ede-b215-63de0174cbb4"
	}
	clientConfiguration = @{
		timeoutInMilliseconds = 2000
		maximumRetries = 1
	}
	claimsForTokenConfiguration = @(
		@{
			claimIdInApiResponse = "DateOfBirth"
		}
		@{
			claimIdInApiResponse = "CustomRoles"
		}
	)
}

New-MgIdentityCustomAuthenticationExtension -BodyParameter $params

```
This example shows how to use the New-MgIdentityCustomAuthenticationExtension Cmdlet.

