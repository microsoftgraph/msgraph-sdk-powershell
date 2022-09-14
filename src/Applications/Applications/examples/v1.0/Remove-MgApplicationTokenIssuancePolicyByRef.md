### Example 1
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgApplicationTokenIssuancePolicyByRef -ApplicationId $applicationId -TokenIssuancePolicyId $tokenIssuancePolicyId
```
