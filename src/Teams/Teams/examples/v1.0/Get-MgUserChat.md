### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId -ChatId $chatId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId -ExpandProperty "members" 
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId
```
