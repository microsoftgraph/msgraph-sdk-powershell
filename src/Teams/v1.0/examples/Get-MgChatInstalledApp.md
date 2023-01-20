### Example 1: Using the Get-MgChatInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId -TeamsAppInstallationId $teamsAppInstallationId
```
This example shows how to use the Get-MgChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgChatInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId -ExpandProperty "teamsApp,teamsAppDefinition" -Filter "teamsApp/externalId eq 'cf1ba4c7-f94e-4d80-ba90-5594b641a8ee'" 
```
This example shows how to use the Get-MgChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgChatInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId -ExpandProperty "teamsAppDefinition(`$expand=bot)" 
```
This example shows how to use the Get-MgChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgChatInstalledApp Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatInstalledApp -ChatId $chatId
```
This example shows how to use the Get-MgChatInstalledApp Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
