### Example 1: Using the Remove-MgApplicationTokenIssuancePolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgApplicationTokenIssuancePolicyByRef -ApplicationId $applicationId -TokenIssuancePolicyId $tokenIssuancePolicyId
```
This example shows how to use the Remove-MgApplicationTokenIssuancePolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
