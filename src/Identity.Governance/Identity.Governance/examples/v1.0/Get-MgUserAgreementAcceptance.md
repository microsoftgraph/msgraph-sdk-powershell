###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
# A UPN can also be used as -UserId.
Get-MgUserAgreementAcceptance -UserId $userId
```
