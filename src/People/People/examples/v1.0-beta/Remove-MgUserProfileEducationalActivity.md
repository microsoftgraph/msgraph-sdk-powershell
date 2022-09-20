### Example 1: Using the Remove-MgUserProfileEducationalActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Remove-MgUserProfileEducationalActivity -UserId $userId -EducationalActivityId $educationalActivityId
```
This example shows how to use the Remove-MgUserProfileEducationalActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
