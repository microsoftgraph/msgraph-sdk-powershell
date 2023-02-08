### Example 1: Using the Remove-MgBetaUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileAnniversary -UserId $userId -PersonAnnualEventId $personAnnualEventId
```
This example shows how to use the Remove-MgBetaUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
