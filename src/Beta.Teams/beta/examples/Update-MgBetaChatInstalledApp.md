### Example 1: Upgrade the teams app installed in chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
}

Update-MgBetaChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId -BodyParameter $params

```
This example will upgrade the teams app installed in chat

### Example 2: Upgrade app installed in a chat and consent to the resource specific permissions

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	consentedPermissionSet = @{
		resourceSpecificPermissions = @(
			@{
				permissionValue = "OnlineMeeting.ReadBasic.Chat"
				permissionType = "Delegated"
			}
			@{
				permissionValue = "ChatMember.Read.Chat"
				permissionType = "Application"
			}
		)
	}
}

Update-MgBetaChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId -BodyParameter $params

```
This example will upgrade app installed in a chat and consent to the resource specific permissions

