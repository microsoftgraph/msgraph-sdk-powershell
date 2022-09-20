### Example 1: Using the Get-MgChatMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMessage -ChatId $chatId -Top 2 -Sort "createdDateTime desc" 
```
This example shows how to use the Get-MgChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgChatMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
