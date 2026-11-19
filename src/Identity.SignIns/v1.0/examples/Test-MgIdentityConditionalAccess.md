### Example 1: Identify conditional access policies that would apply to a user accessing an application

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	signInIdentity = @{
		"@odata.type" = "#microsoft.graph.userSignIn"
		userId = "15dc174b-f34c-4588-ac45-61d6e05dce93"
	}
	signInContext = @{
		"@odata.type" = "#microsoft.graph.applicationContext"
		includeApplications = @(
		"00000003-0000-0ff1-ce00-000000000000"
	)
}
signInConditions = @{
	devicePlatform = "android"
	clientAppType = "browser"
	signInRiskLevel = "high"
	userRiskLevel = "high"
	country = "US"
	ipAddress = "40.77.182.32"
	insiderRiskLevel = "elevated"
	authenticationFlow = @{
		transferMethod = "deviceCodeFlow"
	}
	deviceInfo = @{
		isCompliant = $true
	}
}
appliedPoliciesOnly = $true
}

Test-MgIdentityConditionalAccess -BodyParameter $params

```
This example will identify conditional access policies that would apply to a user accessing an application

### Example 2: Identify conditional access policies that would apply to a user accessing a sensitive file protected by an authentication context

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	signInIdentity = @{
		"@odata.type" = "#microsoft.graph.userSignIn"
		userId = "15dc174b-f34c-4588-ac45-61d6e05dce93"
	}
	signInContext = @{
		"@odata.type" = "#microsoft.graph.authContext"
		authenticationContextValue = "c37"
	}
	signInConditions = @{
		devicePlatform = "windows"
		clientAppType = "mobileAppsAndDesktopClients"
		signInRiskLevel = "medium"
		userRiskLevel = "none"
		country = "US"
		ipAddress = "40.77.182.32"
		insiderRiskLevel = "moderate"
		authenticationFlow = @{
			transferMethod = "authenticationTransfer"
		}
		deviceInfo = @{
			profileType = "Standard"
		}
	}
	appliedPoliciesOnly = $true
}

Test-MgIdentityConditionalAccess -BodyParameter $params

```
This example will identify conditional access policies that would apply to a user accessing a sensitive file protected by an authentication context

### Example 3: Identify conditional access policies that would apply to a user performing a user action

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	signInIdentity = @{
		"@odata.type" = "#microsoft.graph.userSignIn"
		userId = "15dc174b-f34c-4588-ac45-61d6e05dce93"
	}
	signInContext = @{
		"@odata.type" = "#microsoft.graph.userActionContext"
		userAction = "registerSecurityInformation"
	}
	signInConditions = @{
		devicePlatform = "macOS"
		clientAppType = "browser"
		signInRiskLevel = "low"
		userRiskLevel = "high"
		servicePrincipalRiskLevel = "none"
		country = "CA"
		ipAddress = "40.77.182.32"
		insiderRiskLevel = "minor"
		authenticationFlow = @{
			transferMethod = "deviceCodeFlow"
		}
		deviceInfo = @{
			trustType = "EntraID"
		}
	}
	appliedPoliciesOnly = $true
}

Test-MgIdentityConditionalAccess -BodyParameter $params

```
This example will identify conditional access policies that would apply to a user performing a user action

### Example 4: Identify conditional access policies that apply to a service principal

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	signInIdentity = @{
		"@odata.type" = "#microsoft.graph.servicePrincipalSignIn"
		servicePrincipalId = "c65b94a5-0049-439a-a6fd-bce307077730"
	}
	signInContext = @{
		"@odata.type" = "#microsoft.graph.applicationContext"
		includeApplications = @(
		"00000003-0000-0ff1-ce00-000000000000"
	)
}
signInConditions = @{
	servicePrincipalRiskLevel = "high"
	country = "CA"
	ipAddress = "40.77.182.32"
}
appliedPoliciesOnly = $true
}

Test-MgIdentityConditionalAccess -BodyParameter $params

```
This example will identify conditional access policies that apply to a service principal

