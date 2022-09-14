### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId
```
