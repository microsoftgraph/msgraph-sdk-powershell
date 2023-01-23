### Example 1: Using the Get-MgUserPerson Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserPerson -UserId $userId
```
This example shows how to use the Get-MgUserPerson Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
