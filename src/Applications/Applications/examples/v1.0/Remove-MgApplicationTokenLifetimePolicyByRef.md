### Example 1
``` powershell
Import-Module Microsoft.Graph.Applications
Remove-MgApplicationTokenLifetimePolicyByRef -ApplicationId $applicationId -TokenLifetimePolicyId $tokenLifetimePolicyId
```
