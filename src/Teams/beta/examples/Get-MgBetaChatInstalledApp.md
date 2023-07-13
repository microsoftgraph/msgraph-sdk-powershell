### Example 1 : Get the app installed in the specified chat

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId
```
This example shows how to use the Get-MgBetaChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get the set of resource-specific permissions consented for the app installed in the specified chat

```powershellImport-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId -Property "consentedPermissionSet,id"
```
This example shows how to use the Get-MgBetaChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

