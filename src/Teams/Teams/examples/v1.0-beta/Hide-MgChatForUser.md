### Example 1: Using the Hide-MgChatForUser Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	User = @{
		Id = "d864e79f-a516-4d0f-9fee-0eeb4d61fdc2"
	}
	TenantId = "2a690434-97d9-4eed-83a6-f5f13600199a"
}
Hide-MgChatForUser -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Hide-MgChatForUser Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
