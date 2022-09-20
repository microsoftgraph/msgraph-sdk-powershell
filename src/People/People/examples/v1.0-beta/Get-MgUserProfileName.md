### Example 1: Using the Get-MgUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileName -UserId $userId
```
This example shows how to use the Get-MgUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfileName Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfileName -UserId $userId -PersonNameId $personNameId
```
This example shows how to use the Get-MgUserProfileName Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
