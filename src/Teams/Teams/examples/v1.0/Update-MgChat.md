###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = "Group chat title update"
}
Update-MgChat -ChatId $chatId -BodyParameter $params
```
