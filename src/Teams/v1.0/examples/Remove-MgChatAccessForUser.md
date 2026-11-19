### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	user = @{
		"@odata.type" = "microsoft.graph.teamworkUserIdentity"
		id = "f47ac10b-58cc-4372-a567-0e02b2c3d479"
		tenantId = "a1b2c3d4-e5f6-7890-1234-567890abcdef"
	}
}

Remove-MgChatAccessForUser -ChatId $chatId -BodyParameter $params

```
This example shows how to use the Remove-MgChatAccessForUser Cmdlet.

