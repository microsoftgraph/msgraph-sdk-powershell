### Example 1: Using the Get-MgChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId -ExpandProperty "members" 
```
This example shows how to use the Get-MgChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId
```
This example shows how to use the Get-MgChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -ChatId $chatId
```
This example shows how to use the Get-MgChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
Get-MgChat -Sort "lastMessagePreview/createdDateTime desc" 
```
This example shows how to use the Get-MgChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
