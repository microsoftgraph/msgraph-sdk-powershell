### Example 1
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId -ExpandProperty "members" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -Sort "lastMessagePreview/createdDateTime desc" 
```
