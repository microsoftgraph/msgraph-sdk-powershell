###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -ExpandProperty "teamsApp" 
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.web'" 
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" 
```
