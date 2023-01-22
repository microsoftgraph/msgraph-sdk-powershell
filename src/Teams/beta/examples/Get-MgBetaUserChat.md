### Example 1: Using the Get-MgBetaUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserChat -UserId $userId -ChatId $chatId
```
This example shows how to use the Get-MgBetaUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserChat -UserId $userId -ExpandProperty "members" -Filter "members/any(o: o/displayname eq 'Peter Parker')" 
```
This example shows how to use the Get-MgBetaUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserChat -UserId $userId -ExpandProperty "members" 
```
This example shows how to use the Get-MgBetaUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaUserChat Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Teams
Get-MgBetaUserChat -UserId $userId
```
This example shows how to use the Get-MgBetaUserChat Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
