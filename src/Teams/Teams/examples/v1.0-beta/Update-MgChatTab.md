### Example 1: Using the Update-MgBetaChatTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "My Contoso Tab - updated again"
}
Update-MgBetaChatTab -ChatId $chatId -TeamsTabId $teamsTabId -BodyParameter $params
```
This example shows how to use the Update-MgBetaChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
