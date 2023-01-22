### Example 1: Using the New-MgBetaChatTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
$params = @{
	DisplayName = "My Contoso Tab"
	"TeamsApp@odata.bind" = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/06805b9e-77e3-4b93-ac81-525eb87513b8"
	Configuration = @{
		EntityId = "2DCA2E6C7A10415CAF6B8AB6661B3154"
		ContentUrl = "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/tabView"
		WebsiteUrl = "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154"
		RemoveUrl = "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/uninstallTab"
	}
}
New-MgBetaChatTab -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgBetaChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
