### Example 1: Using the Get-MgBetaUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileCertification -UserId $userId
```
This example shows how to use the Get-MgBetaUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Get-MgBetaUserProfileCertification -UserId $userId -PersonCertificationId $personCertificationId
```
This example shows how to use the Get-MgBetaUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
