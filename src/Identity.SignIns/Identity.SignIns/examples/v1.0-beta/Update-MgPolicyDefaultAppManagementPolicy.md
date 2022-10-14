### Example 1: Using the Update-MgPolicyDefaultAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
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
Update-MgPolicyDefaultAppManagementPolicy -BodyParameter $params
```
This example shows how to use the Update-MgPolicyDefaultAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
