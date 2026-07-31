### Example 1: Update an onTokenIssuanceStartCustomExtension object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

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
	claimsForTokenConfiguration = @(
		@{
			claimIdInApiResponse = "DateOfBirth"
		}
		@{
			claimIdInApiResponse = "CustomRoles"
		}
	)
}

Update-MgBetaIdentityCustomAuthenticationExtension -CustomAuthenticationExtensionId $customAuthenticationExtensionId -BodyParameter $params

```
This example will update an ontokenissuancestartcustomextension object

### Example 2: Update an onVerifiedIdClaimValidationCustomExtension object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onVerifiedIdClaimValidationCustomExtension"
	displayName = "Verified ID Claim Validation (updated)"
	description = "Updated description for Verified ID claim validation"
}

Update-MgBetaIdentityCustomAuthenticationExtension -CustomAuthenticationExtensionId $customAuthenticationExtensionId -BodyParameter $params

```
This example will update an onverifiedidclaimvalidationcustomextension object

