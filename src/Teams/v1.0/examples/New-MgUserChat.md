### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserChat -UserId $userId
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgUserChat -UserId $userId -ExpandProperty "members"
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Teams

Get-MgChat -Sort "lastMessagePreview/createdDateTime desc"
```
This example shows how to use the New-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

