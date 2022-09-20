### Example 1: Using the Get-MgUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileCertification -UserId $userId
```
This example shows how to use the Get-MgUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileCertification -UserId $userId -PersonCertificationId $personCertificationId
```
This example shows how to use the Get-MgUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
