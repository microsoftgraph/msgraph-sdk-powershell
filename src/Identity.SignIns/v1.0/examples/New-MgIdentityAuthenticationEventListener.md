### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onTokenIssuanceStartListener"
	conditions = @{
		applications = @{
			includeApplications = @(
				@{
					appId = "a13d0fc1-04ab-4ede-b215-63de0174cbb4"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onTokenIssuanceStartCustomExtensionHandler"
		customExtension = @{
			id = "6fc5012e-7665-43d6-9708-4370863f4e6e"
		}
	}
}

New-MgIdentityAuthenticationEventListener -BodyParameter $params

```
This example shows how to use the New-MgIdentityAuthenticationEventListener Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onFraudProtectionLoadStartListener"
	conditions = @{
		applications = @{
			includeApplications = @(
				@{
					appId = "0001111-aaaa-2222-bbbb-3333cccc4444"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onFraudProtectionLoadStartExternalUsersAuthHandler"
		signUp = @{
			"@odata.type" = "#microsoft.graph.fraudProtectionProviderConfiguration"
			fraudProtectionProvider = @{
				"@odata.type" = "#microsoft.graph.arkoseFraudProtectionProvider"
				id = "6fedd01b-0afb-4a07-967f-d1ccbd81102b"
			}
		}
	}
}

New-MgIdentityAuthenticationEventListener -BodyParameter $params

```
This example shows how to use the New-MgIdentityAuthenticationEventListener Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onFraudProtectionLoadStartListener"
	conditions = @{
		applications = @{
			includeApplications = @(
				@{
					appId = "0001111-aaaa-2222-bbbb-3333cccc4444"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onFraudProtectionLoadStartExternalUsersAuthHandler"
		signUp = @{
			"@odata.type" = "#microsoft.graph.fraudProtectionProviderConfiguration"
			fraudProtectionProvider = @{
				"@odata.type" = "#microsoft.graph.humanSecurityFraudProtectionProvider"
				id = "fabe5100-cc02-46c1-bd0e-ce885fe367fd"
			}
		}
	}
}

New-MgIdentityAuthenticationEventListener -BodyParameter $params

```
This example shows how to use the New-MgIdentityAuthenticationEventListener Cmdlet.

