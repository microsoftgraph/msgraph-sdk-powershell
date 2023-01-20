### Example 1: Using the Update-MgBetaChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	Topic = "Group chat title update"
}
Update-MgBetaChat -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Update-MgBetaChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
