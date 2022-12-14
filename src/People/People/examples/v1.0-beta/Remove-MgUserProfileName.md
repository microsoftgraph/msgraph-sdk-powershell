### Example 1: Using the Remove-MgBetaUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileName -UserId $userId -PersonNameId $personNameId
```
This example shows how to use the Remove-MgBetaUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
