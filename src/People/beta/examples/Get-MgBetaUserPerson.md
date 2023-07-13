### Example 1: Using the Get-MgBetaUserPerson Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserPerson -UserId $userId
```
This example shows how to use the Get-MgBetaUserPerson Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
