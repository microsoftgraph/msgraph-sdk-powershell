### Example 1: Using the Get-MgUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfile -UserId $userId
```
This example shows how to use the Get-MgUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfile -UserId $userId -ExpandProperty "names(`$select=first,last),skills(`$select=displayName)" 
```
This example shows how to use the Get-MgUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
