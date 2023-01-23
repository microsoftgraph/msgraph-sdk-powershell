### Example 1: Using the Remove-MgBetaUserProfileEducationalActivity Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileEducationalActivity -UserId $userId -EducationalActivityId $educationalActivityId
```
This example shows how to use the Remove-MgBetaUserProfileEducationalActivity Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
