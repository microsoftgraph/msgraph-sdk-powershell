### Example 1: Using the Get-MgUserProfileEducationalActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileEducationalActivity -UserId $userId
```
This example shows how to use the Get-MgUserProfileEducationalActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileEducationalActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileEducationalActivity -UserId $userId -EducationalActivityId $educationalActivityId
```
This example shows how to use the Get-MgUserProfileEducationalActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
