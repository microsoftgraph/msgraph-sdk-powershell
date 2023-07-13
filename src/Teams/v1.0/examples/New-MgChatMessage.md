### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	body = @{
		content = "Hello world"
	}
}

New-MgChatMessage -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

