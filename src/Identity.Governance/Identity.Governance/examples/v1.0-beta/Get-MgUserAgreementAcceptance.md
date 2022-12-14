### Example 1: Using the Get-MgBetaUserAgreementAcceptance Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
# A UPN can also be used as -UserId.
Get-MgBetaUserAgreementAcceptance -UserId $userId
```
This example shows how to use the Get-MgBetaUserAgreementAcceptance Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
