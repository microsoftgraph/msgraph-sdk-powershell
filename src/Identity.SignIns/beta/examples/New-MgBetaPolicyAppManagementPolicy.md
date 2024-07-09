### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Credential management policy"
	description = "Cred policy sample"
	isEnabled = $true
	restrictions = @{
		passwordCredentials = @(
			@{
				restrictionType = "passwordAddition"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2019-10-19T10:37:00Z")
			}
			@{
				restrictionType = "passwordLifetime"
				maxLifetime = "P90D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2014-10-19T10:37:00Z")
			}
			@{
				restrictionType = "symmetricKeyAddition"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2019-10-19T10:37:00Z")
			}
			@{
				restrictionType = "symmetricKeyLifetime"
				maxLifetime = "P30D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2014-10-19T10:37:00Z")
			}
		)
		keyCredentials = @(
			@{
				restrictionType = "asymmetricKeyLifetime"
				maxLifetime = "P90D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2014-10-19T10:37:00Z")
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
}
}

New-MgBetaPolicyAppManagementPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyAppManagementPolicy Cmdlet.

