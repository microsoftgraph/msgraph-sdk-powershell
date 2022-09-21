### Example 1: Using the Get-MgUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileNote -UserId $userId
```
This example shows how to use the Get-MgUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileNote -UserId $userId -PersonAnnotationId $personAnnotationId
```
This example shows how to use the Get-MgUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
