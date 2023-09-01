### Example 1: Install app in a chat

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/12345678-9abc-def0-123456789a"
}

New-MgBetaChatInstalledApp -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Install app in a chat and and consent to the resource-specific permissions required by the app

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/2b524e28-95ce-4c9b-9773-4a5bd6ec1770"
	consentedPermissionSet = @{
		resourceSpecificPermissions = @(
			@{
				permissionValue = "OnlineMeeting.ReadBasic.Chat"
				permissionType = "Delegated"
			}
			@{
				permissionValue = "OnlineMeetingIncomingAudio.Detect.Chat"
				permissionType = "Delegated"
			}
			@{
				permissionValue = "ChatMember.Read.Chat"
				permissionType = "Application"
			}
			@{
				permissionValue = "ChatMessage.Read.Chat"
				permissionType = "Application"
			}
		)
	}
}

New-MgBetaChatInstalledApp -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

