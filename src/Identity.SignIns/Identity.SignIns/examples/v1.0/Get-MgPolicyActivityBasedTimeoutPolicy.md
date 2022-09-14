### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyActivityBasedTimeoutPolicy
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyActivityBasedTimeoutPolicy -ActivityBasedTimeoutPolicyId $activityBasedTimeoutPolicyId
```
