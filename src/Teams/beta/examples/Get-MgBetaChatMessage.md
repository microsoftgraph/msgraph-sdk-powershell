### Example 1: Using the Get-MgBetaChatMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChatMessage -ChatId $chatId -Top 2 -Sort "createdDateTime desc" 
```
This example shows how to use the Get-MgBetaChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaChatMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChatMessage -ChatId $chatId -ChatMessageId $chatMessageId
```
This example shows how to use the Get-MgBetaChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
