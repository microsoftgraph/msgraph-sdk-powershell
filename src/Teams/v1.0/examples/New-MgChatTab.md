### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

$params = @{
	displayName = "My Contoso Tab"
	"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps/06805b9e-77e3-4b93-ac81-525eb87513b8"
	configuration = @{
		entityId = "2DCA2E6C7A10415CAF6B8AB6661B3154"
		contentUrl = "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/tabView"
		websiteUrl = "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154"
		removeUrl = "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/uninstallTab"
	}
}

New-MgChatTab -ChatId $chatId -BodyParameter $params
```
This example shows how to use the New-MgChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

