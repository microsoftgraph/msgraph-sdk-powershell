### Example 1: Using the Get-MgBetaChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChatPinnedMessage -ChatId $chatId -ExpandProperty "message"  -OutFile $outFileId
```
This example shows how to use the Get-MgBetaChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChatPinnedMessage -ChatId $chatId -ExpandProperty "message" 
```
This example shows how to use the Get-MgBetaChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaChatPinnedMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaChatPinnedMessage -ChatId $chatId
```
This example shows how to use the Get-MgBetaChatPinnedMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
