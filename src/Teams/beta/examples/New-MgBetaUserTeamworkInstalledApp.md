### Example 1: Install an app for a user

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}

New-MgBetaUserTeamworkInstalledApp -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Install an app for a user and consent to the resource-specific permissions required by the app

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
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
This example shows how to use the New-MgBetaUserTeamworkInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

