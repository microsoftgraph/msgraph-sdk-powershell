### Example 1: Using the Update-MgChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = "Group chat title update"
}
Update-MgChat -ChatId $chatId -BodyParameter $params
```
This example shows how to use the Update-MgChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
