### Example 1: Get all the apps installed in the specified chat

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatInstalledApp -ChatId $chatId
```
This example shows how to use the New-MgUserChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the names and other details of apps installed in the specified chat

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatInstalledApp -ChatId $chatId -ExpandProperty "teamsAppDefinition(`$expand=bot)"
```
This example shows how to use the New-MgUserChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get the app installation resource based on the manifest id of the associated app

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatInstalledApp -ChatId $chatId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'"
```
This example shows how to use the New-MgUserChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

