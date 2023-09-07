### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}

New-MgTeamInstalledApp -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamInstalledApp Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/7023576d-9e40-47ca-9cf2-daae6838e785"
	consentedPermissionSet = @{
		resourceSpecificPermissions = @(
			@{
				permissionValue = "OnlineMeeting.ReadBasic.Chat"
				permissionType = "delegated"
			}
			@{
				permissionValue = "ChatMessage.Read.Chat"
				permissionType = "application"
			}
		)
	}
}

New-MgTeamInstalledApp -TeamId $teamId -BodyParameter $params

```
This example shows how to use the New-MgTeamInstalledApp Cmdlet.

