### Example 1: Using the Get-MgChatTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -TeamsTabId $teamsTabId -ExpandProperty "teamsApp" 
```
This example shows how to use the Get-MgChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgChatTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" -Filter "teamsApp/id eq 'com.microsoft.teamspace.tab.web'" 
```
This example shows how to use the Get-MgChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgChatTab Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatTab -ChatId $chatId -ExpandProperty "teamsApp" 
```
This example shows how to use the Get-MgChatTab Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
