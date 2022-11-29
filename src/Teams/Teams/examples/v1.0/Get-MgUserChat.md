### Example 1: Using the Get-MgUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId -ChatId $chatId
```
This example shows how to use the Get-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId -ExpandProperty "members" 
```
This example shows how to use the Get-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgUserChat -UserId $userId
```
This example shows how to use the Get-MgUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
