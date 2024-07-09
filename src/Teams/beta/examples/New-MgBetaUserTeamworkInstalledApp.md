### Example 1: Install an app for a user

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}

New-MgBetaUserTeamworkInstalledApp -UserId $userId -BodyParameter $params

```
This example will install an app for a user

### Example 2: Install an app for a user and consent to the resource-specific permissions required by the app

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
	consentedPermissionSet = @{
		resourceSpecificPermissions = @(
			@{
				permissionValue = "TeamsActivity.Send.User"
				permissionType = "Application"
			}
		)
	}
}

New-MgBetaUserTeamworkInstalledApp -UserId $userId -BodyParameter $params

```
This example will install an app for a user and consent to the resource-specific permissions required by the app

