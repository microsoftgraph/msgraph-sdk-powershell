### Example 1: Require MFA to access Exchange Online outside of trusted locations

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Access to EXO requires MFA"
	state = "enabled"
	conditions = @{
		clientAppTypes = @(
			"mobileAppsAndDesktopClients"
			"browser"
		)
		applications = @{
			includeApplications = @(
				"00000002-0000-0ff1-ce00-000000000000"
			)
		}
		users = @{
			includeGroups = @(
				"ba8e7ded-8b0f-4836-ba06-8ff1ecc5c8ba"
			)
		}
		locations = @{
			includeLocations = @(
				"All"
			)
			excludeLocations = @(
				"AllTrusted"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"mfa"
		)
	}
}

New-MgIdentityConditionalAccessPolicy -BodyParameter $params
```
This example shows how to use the New-MgIdentityConditionalAccessPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Block access to Exchange Online from non-trusted regions

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Block access to EXO non-trusted regions."
	state = "enabled"
	conditions = @{
		clientAppTypes = @(
			"all"
		)
		applications = @{
			includeApplications = @(
				"00000002-0000-0ff1-ce00-000000000000"
			)
		}
		users = @{
			includeGroups = @(
				"ba8e7ded-8b0f-4836-ba06-8ff1ecc5c8ba"
			)
		}
		locations = @{
			includeLocations = @(
				"198ad66e-87b3-4157-85a3-8a7b51794ee9"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"block"
		)
	}
}

New-MgIdentityConditionalAccessPolicy -BodyParameter $params
```
This example shows how to use the New-MgIdentityConditionalAccessPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Use all conditions and controls

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Demo app for documentation"
	state = "disabled"
	conditions = @{
		signInRiskLevels = @(
			"high"
			"medium"
		)
		clientAppTypes = @(
			"mobileAppsAndDesktopClients"
			"exchangeActiveSync"
			"other"
		)
		applications = @{
			includeApplications = @(
				"All"
			)
			excludeApplications = @(
				"499b84ac-1321-427f-aa17-267ca6975798"
				"00000007-0000-0000-c000-000000000000"
				"de8bc8b5-d9f9-48b1-a8ad-b748da725064"
				"00000012-0000-0000-c000-000000000000"
				"797f4846-ba00-4fd7-ba43-dac1f8f63013"
				"05a65629-4c1b-48c1-a78b-804c4abdd4af"
				"7df0a125-d3be-4c96-aa54-591f83ff541c"
			)
			includeUserActions = @(
			)
		}
		users = @{
			includeUsers = @(
				"a702a13d-a437-4a07-8a7e-8c052de62dfd"
			)
			excludeUsers = @(
				"124c5b6a-ffa5-483a-9b88-04c3fce5574a"
				"GuestsOrExternalUsers"
			)
			includeGroups = @(
			)
			excludeGroups = @(
			)
			includeRoles = @(
				"9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
				"cf1c38e5-3621-4004-a7cb-879624dced7c"
				"c4e39bd9-1100-46d3-8c65-fb160da0071f"
			)
			excludeRoles = @(
				"b0f54661-2d74-4c50-afa3-1ec803f12efe"
			)
		}
		platforms = @{
			includePlatforms = @(
				"all"
			)
			excludePlatforms = @(
				"iOS"
				"windowsPhone"
			)
		}
		locations = @{
			includeLocations = @(
				"AllTrusted"
			)
			excludeLocations = @(
				"00000000-0000-0000-0000-000000000000"
				"d2136c9c-b049-47ae-b9cf-316e04ef7198"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"mfa"
			"compliantDevice"
			"domainJoinedDevice"
			"approvedApplication"
			"compliantApplication"
		)
		customAuthenticationFactors = @(
		)
		termsOfUse = @(
			"ce580154-086a-40fd-91df-8a60abac81a0"
			"7f29d675-caff-43e1-8a53-1b8516ed2075"
		)
	}
	sessionControls = @{
		applicationEnforcedRestrictions = $null
		persistentBrowser = $null
		cloudAppSecurity = @{
			cloudAppSecurityType = "blockDownloads"
			isEnabled = $true
		}
		signInFrequency = @{
			value = 4
			type = "hours"
			isEnabled = $true
		}
	}
}

New-MgIdentityConditionalAccessPolicy -BodyParameter $params
```
This example shows how to use the New-MgIdentityConditionalAccessPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Require MFA to Exchange Online from non-compliant devices

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Require MFA to EXO from non-compliant devices."
	state = "enabled"
	conditions = @{
		applications = @{
			includeApplications = @(
				"00000002-0000-0ff1-ce00-000000000000"
			)
		}
		users = @{
			includeGroups = @(
				"ba8e7ded-8b0f-4836-ba06-8ff1ecc5c8ba"
			)
		}
	}
	grantControls = @{
		operator = "OR"
		builtInControls = @(
			"mfa"
		)
	}
}

New-MgIdentityConditionalAccessPolicy -BodyParameter $params
```
This example shows how to use the New-MgIdentityConditionalAccessPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

