### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	user = @{
		"@odata.type" = "microsoft.graph.teamworkUserIdentity"
	}
}

Remove-MgBetaChatAccessForUser -ChatId $chatId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaChatAccessForUser Cmdlet.

