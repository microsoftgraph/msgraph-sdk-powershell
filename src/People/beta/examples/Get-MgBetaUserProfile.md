### Example 1: Using the Get-MgBetaUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfile -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfile Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfile -UserId $userId -ExpandProperty "names(`$select=first,last),skills(`$select=displayName)" 
```
This example shows how to use the Get-MgBetaUserProfile Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
