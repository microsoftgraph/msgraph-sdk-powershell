### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	Topic = "Group chat title update"
}

Update-MgBetaChat -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

