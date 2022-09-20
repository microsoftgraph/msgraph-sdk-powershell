### Example 1: Using the Remove-MgUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileAnniversary -UserId $userId -PersonAnnualEventId $personAnnualEventId
```
This example shows how to use the Remove-MgUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
