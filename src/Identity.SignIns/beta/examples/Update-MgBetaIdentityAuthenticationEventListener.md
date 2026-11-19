### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onTokenIssuanceStartListener"
	conditions = @{
		applications = @{
			includeAllApplications = $false
		}
	}
	priority = 500
}

Update-MgBetaIdentityAuthenticationEventListener -AuthenticationEventListenerId $authenticationEventListenerId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityAuthenticationEventListener Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onVerifiedIdClaimValidationListener"
	displayName = "Verified ID Claim Validation Listener (updated)"
	handler = @{
		"@odata.type" = "#microsoft.graph.onVerifiedIdClaimValidationCustomExtensionHandler"
		configuration = @{
			"@odata.type" = "#microsoft.graph.customExtensionOverwriteConfiguration"
			clientConfiguration = @{
				"@odata.type" = "#microsoft.graph.customExtensionClientConfiguration"
				maximumRetries = 
				timeoutInMilliseconds = 
			}
			behaviorOnError = @{
				"@odata.type" = "#microsoft.graph.customExtensionBehaviorOnError"
			}
		}
	}
}

Update-MgBetaIdentityAuthenticationEventListener -AuthenticationEventListenerId $authenticationEventListenerId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityAuthenticationEventListener Cmdlet.

