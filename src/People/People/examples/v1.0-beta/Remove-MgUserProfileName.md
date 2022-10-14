### Example 1: Using the Remove-MgUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileName -UserId $userId -PersonNameId $personNameId
```
This example shows how to use the Remove-MgUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
