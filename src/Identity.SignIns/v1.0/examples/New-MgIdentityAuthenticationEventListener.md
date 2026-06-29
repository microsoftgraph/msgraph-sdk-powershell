### Example 1: Create authenticationEventListener

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
This example will create authenticationeventlistener

### Example 2: Enable Fraud Protection during sign-up with Arkose Labs

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
This example will enable fraud protection during sign-up with arkose labs

### Example 3: Enable Fraud Protection during sign-up with HUMAN Security

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
This example will enable fraud protection during sign-up with human security

### Example 4: Create an onPasswordSubmitListener object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.onPasswordSubmitListener"
	displayName = "JIT migration listener"
	conditions = @{
		applications = @{
			includeAllApplications = $false
			includeApplications = @(
				@{
					appId = "00011111-aaaa-2222-bbbb-3333cccc4444"
				}
			)
		}
	}
	handler = @{
		"@odata.type" = "#microsoft.graph.onPasswordMigrationCustomExtensionHandler"
		migrationPropertyId = "extension_b7b1c57b532f40b8b5ed4b7a7ba67401_requiresMigration"
		customExtension = @{
			id = "6fc5012e-7665-43d6-9708-4370863f4e6e"
		}
	}
}

New-MgIdentityAuthenticationEventListener -BodyParameter $params

```
This example will create an onpasswordsubmitlistener object

