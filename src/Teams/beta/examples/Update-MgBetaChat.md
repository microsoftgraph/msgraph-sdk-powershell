### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	topic = "Group chat title update"
}

Update-MgBetaChat -ChatId $chatId -BodyParameter $params

```
This example shows how to use the Update-MgBetaChat Cmdlet.

