### Example 1: Using the Remove-MgBetaUserOnenotePage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
# A UPN can also be used as -UserId.
Remove-MgBetaUserOnenotePage -UserId $userId -OnenotePageId $onenotePageId
```
This example shows how to use the Remove-MgBetaUserOnenotePage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
