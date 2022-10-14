### Example 1: Using the Remove-MgUserOnenotePage Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Remove-MgUserOnenotePage -UserId $userId -OnenotePageId $onenotePageId
```
This example shows how to use the Remove-MgUserOnenotePage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
