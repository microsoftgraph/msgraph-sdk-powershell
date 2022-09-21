### Example 1: Using the Get-MgChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatPinnedMessage -ChatId $chatId -ExpandProperty "message"  -OutFile $outFileId
```
This example shows how to use the Get-MgChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatPinnedMessage -ChatId $chatId -ExpandProperty "message" 
```
This example shows how to use the Get-MgChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChatPinnedMessage -ChatId $chatId
```
This example shows how to use the Get-MgChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
