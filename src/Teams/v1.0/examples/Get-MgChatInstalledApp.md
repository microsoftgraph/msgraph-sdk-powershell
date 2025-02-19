### Example 1 : Get the app installed in the specified chat

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId

```
This example will get the app installed in the specified chat

### Example 2: Get the set of resource-specific permissions consented for the app installed in the specified chat

```powershell

Import-Module Microsoft.Graph.Teams

Get-MgChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId -Property "consentedPermissionSet,id" 

```
This example will get the set of resource-specific permissions consented for the app installed in the specified chat

