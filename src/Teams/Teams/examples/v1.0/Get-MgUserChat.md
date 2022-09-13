###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId -ChatId $chatId
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId -ExpandProperty "members" 
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId
```
