### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.Governance
# A UPN can also be used as -UserId.
Get-MgUserAgreementAcceptance -UserId $userId
```
