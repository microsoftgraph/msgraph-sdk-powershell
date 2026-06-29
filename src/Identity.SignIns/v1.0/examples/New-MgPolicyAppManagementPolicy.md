### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Credential management policy"
	description = "Cred policy sample"
	isEnabled = $true
	restrictions = @{
		passwordCredentials = @(
			@{
				restrictionType = "passwordAddition"
				state = "enabled"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2019-10-19T10:37:00Z")
			}
			@{
				restrictionType = "passwordLifetime"
				state = "enabled"
				maxLifetime = "P90D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2014-10-19T10:37:00Z")
			}
			@{
				restrictionType = "symmetricKeyAddition"
				state = "enabled"
				maxLifetime = $null
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2019-10-19T10:37:00Z")
			}
			@{
				restrictionType = "symmetricKeyLifetime"
				state = "enabled"
				maxLifetime = "P90D"
				restrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2014-10-19T10:37:00Z")
			}
		)
		keyCredentials = @(
		)
		applicationRestrictions = @{
			identifierUris = @{
				nonDefaultUriAddition = @{
					state = "disabled"
					excludeAppsReceivingV2Tokens = $true
					excludeSaml = $true
				}
			}
		}
	}
}

New-MgPolicyAppManagementPolicy -BodyParameter $params

```
This example shows how to use the New-MgPolicyAppManagementPolicy Cmdlet.

