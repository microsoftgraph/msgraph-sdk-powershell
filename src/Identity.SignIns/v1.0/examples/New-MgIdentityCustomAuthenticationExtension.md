### Example 1: Create an onTokenIssuanceStartCustomExtension object

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
This example will create an ontokenissuancestartcustomextension object

### Example 2: Create an onAttributeCollectionStartCustomExtension object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onAttributeCollectionStartCustomExtension"
	displayName = "attributeCollectionStartName"
	description = "example description"
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		resourceId = "api://contoso.com/fb96de85-2abe-4b02-b45f-64ba122c509e"
	}
	endpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.httpRequestEndpoint"
		targetUrl = "https://contoso.com"
	}
	clientConfiguration = @{
		timeoutInMilliseconds = 2000
		maximumRetries = 1
	}
}

New-MgIdentityCustomAuthenticationExtension -BodyParameter $params

```
This example will create an onattributecollectionstartcustomextension object

### Example 3: Create an onAttributeCollectionSubmitCustomExtension object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onAttributeCollectionSubmitCustomExtension"
	displayName = "attributeCollectionSubmitName"
	description = "example description"
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		resourceId = "api://contoso.com/fb96de85-2abe-4b02-b45f-64ba122c509e"
	}
	endpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.httpRequestEndpoint"
		targetUrl = "https://contoso.com"
	}
	clientConfiguration = @{
		timeoutInMilliseconds = 2000
		maximumRetries = 1
	}
}

New-MgIdentityCustomAuthenticationExtension -BodyParameter $params

```
This example will create an onattributecollectionsubmitcustomextension object

### Example 4: Create an onOtpSendCustomExtension object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onOtpSendCustomExtension"
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.azureAdTokenAuthentication"
		resourceId = "api://onotpsendcustomextension.b2c.expert/fb96de85-2abe-4b02-b45f-64ba122c509e"
	}
	clientConfiguration = @{
		timeoutInMilliseconds = 2000
		maximumRetries = 1
	}
	description = "Use an external Email provider to send OTP Codes."
	displayName = "onEmailOtpSendCustomExtension"
	endpointConfiguration = @{
		"@odata.type" = "#microsoft.graph.httpRequestEndpoint"
		targetUrl = "https://onotpsendcustomextension.b2c.expert/api/OnOTPCodeSendToTeamsDemo"
	}
	behaviorOnError = @{
		"@odata.type" = "microsoft.graph.customExtensionBehaviorOnError"
	}
}

New-MgIdentityCustomAuthenticationExtension -BodyParameter $params

```
This example will create an onotpsendcustomextension object

