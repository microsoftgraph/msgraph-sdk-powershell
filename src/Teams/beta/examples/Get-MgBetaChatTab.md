### Example 1: List all the tabs in the chat along with associated Teams app

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatTab -ChatId $chatId -ExpandProperty "teamsApp" 

```
This example will list all the tabs in the chat along with associated teams app

### Example 2: List all the tabs belonging to a specific app in a chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChatTab -ChatId $chatId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.web'" 

```
This example will list all the tabs belonging to a specific app in a chat

