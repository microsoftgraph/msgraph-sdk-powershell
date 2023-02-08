### Example 1: Using the Update-MgBetaPolicyDefaultAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	IsEnabled = $true
	ApplicationRestrictions = @{
		PasswordCredentials = @(
			@{
				RestrictionType = "passwordAddition"
				MaxLifetime = $null
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2021-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "passwordLifetime"
				MaxLifetime = "P4DT12H30M5S"
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2017-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "symmetricKeyAddition"
				MaxLifetime = $null
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2021-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "customPasswordAddition"
				MaxLifetime = $null
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "symmetricKeyLifetime"
				MaxLifetime = "P40D"
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
		)
		KeyCredentials = @(
			@{
				RestrictionType = "asymmetricKeyLifetime"
				MaxLifetime = "P30D"
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
		)
	}
}
Update-MgBetaPolicyDefaultAppManagementPolicy -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyDefaultAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
