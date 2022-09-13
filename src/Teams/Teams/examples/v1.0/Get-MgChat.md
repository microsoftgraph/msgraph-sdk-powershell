###Example 1
```
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId -ExpandProperty "members" 
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId
```
###Example 4
```
Import-Module Microsoft.Graph.Teams
Get-MgChat -Sort "lastMessagePreview/createdDateTime desc" 
```
