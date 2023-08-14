### Example 1: Get all the apps installed in the specified chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatInstalledApp -ChatId $chatId

```
This example will get all the apps installed in the specified chat

### Example 2: Get the names and other details of apps installed in the specified chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatInstalledApp -ChatId $chatId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 

```
This example will get the names and other details of apps installed in the specified chat

### Example 3: Get the app installation resource based on the manifest id of the associated app

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatInstalledApp -ChatId $chatId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 

```
This example will get the app installation resource based on the manifest id of the associated app

### Example 4: Get the set of resource specific permissions consented for the apps installed in the specified chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatInstalledApp -ChatId $chatId -Property "consentedPermissionSet,id" 

```
This example will get the set of resource specific permissions consented for the apps installed in the specified chat

