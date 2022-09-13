###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo" 
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId
```
