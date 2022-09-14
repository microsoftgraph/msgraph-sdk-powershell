### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = "Group chat title update"
}
Update-MgChat -ChatId $chatId -BodyParameter $params
```
