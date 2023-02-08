### Example 1: Using the Get-MgBetaUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileNote -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileNote Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileNote -UserId $userId -PersonAnnotationId $personAnnotationId
```
This example shows how to use the Get-MgBetaUserProfileNote Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
