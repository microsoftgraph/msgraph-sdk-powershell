### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	isEnabled = $true
	applicationRestrictions = @{
		passwordCredentials = @(
			@{
				restrictionType = "passwordAddition"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2021-01-01T10:37:00Z")
			}
			@{
				restrictionType = "passwordLifetime"
				maxLifetime = "P90D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2017-01-01T10:37:00Z")
			}
			@{
				restrictionType = "symmetricKeyAddition"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2021-01-01T10:37:00Z")
			}
			@{
				restrictionType = "customPasswordAddition"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
			@{
				restrictionType = "symmetricKeyLifetime"
				maxLifetime = "P30D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
		)
		keyCredentials = @(
			@{
				restrictionType = "asymmetricKeyLifetime"
				maxLifetime = "P30D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
			@{
				restrictionType = "trustedCertificateAuthority"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2019-10-19T10:37:00Z")
				certificateBasedApplicationConfigurationIds = @(
				"eec5ba11-2fc0-4113-83a2-ed986ed13743"
			"bb8e164b-f9ed-4b98-bc45-65eddc14f4c1"
		)
		maxLifetime = $null
	}
)
identifierUris = @{
	nonDefaultUriAddition = @{
		restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2024-01-01T10:37:00Z")
		excludeAppsReceivingV2Tokens = $true
		excludeSaml = $true
		excludeActors = @{
			customSecurityAttributes = @(
				@{
					"@odata.type" = "microsoft.graph.customSecurityAttributeStringValueExemption"
					id = "PolicyExemptions_AppManagementExemption"
					operator = "equals"
					value = "ExemptFromIdentifierUriAdditionRestriction"
				}
			)
		}
	}
}
redirectUris = @{
	uriWithBlockedScheme = @{
		state = "enabled"
		blockedSchemes = @(
		"http"
	"ftp"
)
exemptFormats = @(
"http://example.com/login"
)
web = @{
blockedSchemes = @(
"custom-ftps"
)
}
spa = @{
blockedSchemes = @(
"myapp"
)
exemptFormats = @(
"https://spa.example.com/auth"
)
}
publicClient = @{
blockedSchemes = @(
"msauth"
)
exemptFormats = @(
"https://public.example.com/auth"
)
}
}
uriWithoutAllowedScheme = @{
state = "enabled"
allowedSchemes = @(
"https"
)
web = @{
allowedSchemes = @(
"https"
)
}
spa = @{
allowedSchemes = @(
"https"
"msal"
)
}
publicClient = @{
allowedSchemes = @(
"myapp"
)
}
}
uriWithBlockedDomain = @{
state = "enabled"
blockedDomains = @(
"contoso-short.com"
"tempuri.org"
)
web = @{
blockedDomains = @(
"short.contoso.com"
)
}
spa = @{
blockedDomains = @(
"contoso.dev"
)
}
publicClient = @{
blockedDomains = @(
"mspreview.contoso.com"
)
}
}
uriWithoutAllowedDomain = @{
state = "enabled"
allowedDomains = @(
"contoso.com"
"login.microsoftonline.com"
)
web = @{
allowedDomains = @(
"app.contoso.com"
)
}
spa = @{
allowedDomains = @(
"spa.contoso.com"
)
}
publicClient = @{
allowedDomains = @(
"app://contoso"
)
}
}
uriWithWildcard = @{
state = "enabled"
excludeFormats = @{
excludeWildcardsInPath = $true
excludeWildcardsInPathWithDomains = @(
"contoso.com"
"fabrikam.com"
)
}
}
}
}
}

Update-MgBetaPolicyDefaultAppManagementPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyDefaultAppManagementPolicy Cmdlet.

