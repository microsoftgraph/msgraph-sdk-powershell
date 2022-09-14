### Example 1
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -ExpandProperty "teamsApp" 
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.web'" 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" 
```
