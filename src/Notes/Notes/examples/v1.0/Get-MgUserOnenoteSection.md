### Example 1
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteSection -UserId $userId -OnenoteSectionId $onenoteSectionId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteSection -UserId $userId
```
