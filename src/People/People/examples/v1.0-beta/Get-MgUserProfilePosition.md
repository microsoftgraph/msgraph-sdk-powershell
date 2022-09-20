### Example 1: Using the Get-MgUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePosition -UserId $userId
```
This example shows how to use the Get-MgUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserProfilePosition Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserProfilePosition -UserId $userId -WorkPositionId $workPositionId
```
This example shows how to use the Get-MgUserProfilePosition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
