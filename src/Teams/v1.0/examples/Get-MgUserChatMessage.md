### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatMessage -ChatId $chatId -Top 2
```
This example shows how to use the Get-MgUserChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatMessage -ChatId $chatId -Top 2 -Sort "createdDateTime desc"
```
This example shows how to use the Get-MgUserChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChatMessage -ChatId $chatId -Top 2 -Sort "lastModifiedDateTime desc" -Filter "lastModifiedDateTime ge 2022-09-22T00:00:00.000Z and lastModifiedDateTime le 2022-09-24T00:00:00.000Z"
```
This example shows how to use the Get-MgUserChatMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

