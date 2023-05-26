### Example 1: List all chats

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserChat -UserId $userId
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all chats along with the members of each chat

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserChat -UserId $userId -ExpandProperty "members"
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: List all chats in order of the most to least recent chat messages

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChat -Sort "lastMessagePreview/createdDateTime desc"
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: List chats along with the preview of the last message sent in the chat

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChat -ExpandProperty "lastMessagePreview"
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

