### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Teams

$params = @{
	body = @{
		content = "Hello world"
	}
}

New-MgBetaChatMessage -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

