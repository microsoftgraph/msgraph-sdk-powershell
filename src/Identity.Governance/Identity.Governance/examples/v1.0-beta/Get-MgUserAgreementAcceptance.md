### Example 1: Using the Get-MgUserAgreementAcceptance Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
# A UPN can also be used as -UserId.
Get-MgUserAgreementAcceptance -UserId $userId
```
This example shows how to use the Get-MgUserAgreementAcceptance Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
