### Example 1: Using the Get-MgUserOnenoteOperation Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteOperation -UserId $userId -OnenoteOperationId $onenoteOperationId
```
This example shows how to use the Get-MgUserOnenoteOperation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
