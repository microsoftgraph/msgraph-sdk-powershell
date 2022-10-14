### Example 1: Using the Get-MgUserOnenoteSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteSection -UserId $userId -OnenoteSectionId $onenoteSectionId
```
This example shows how to use the Get-MgUserOnenoteSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserOnenoteSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteSection -UserId $userId
```
This example shows how to use the Get-MgUserOnenoteSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
