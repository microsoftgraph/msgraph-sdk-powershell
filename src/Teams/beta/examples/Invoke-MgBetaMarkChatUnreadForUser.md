### Example 1: Using the Invoke-MgBetaMarkChatUnreadForUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	User = @{
		Id = "d864e79f-a516-4d0f-9fee-0eeb4d61fdc2"
	}
	TenantId = "2a690434-97d9-4eed-83a6-f5f13600199a"
	LastMessageReadDateTime = [System.DateTime]::Parse("2021-05-27T22:13:01.577Z")
}
Invoke-MgBetaMarkChatUnreadForUser -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaMarkChatUnreadForUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
