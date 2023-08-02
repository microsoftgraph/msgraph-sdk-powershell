### Example 1: Get a feature rollout policy

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId

```
This example will get a feature rollout policy

### Example 2: Get a feature rollout policy and expand appliesTo

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo" 

```
This example will get a feature rollout policy and expand appliesto

