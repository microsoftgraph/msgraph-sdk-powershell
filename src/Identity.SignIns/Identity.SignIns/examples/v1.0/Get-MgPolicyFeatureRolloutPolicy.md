### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo" 
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId
```
