### Example 1
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Remove-MgUserOnenotePage -UserId $userId -OnenotePageId $onenotePageId
```
