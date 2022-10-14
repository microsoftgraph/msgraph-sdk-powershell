### Example 1: Using the Get-MgUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAnniversary -UserId $userId
```
This example shows how to use the Get-MgUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileAnniversary -UserId $userId -PersonAnnualEventId $personAnnualEventId
```
This example shows how to use the Get-MgUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
