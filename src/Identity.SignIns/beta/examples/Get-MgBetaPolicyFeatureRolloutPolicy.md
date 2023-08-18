### Example 1: Get a feature rollout policy

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId

```
This example will get a feature rollout policy

### Example 2: Get a feature rollout policy and expand appliesTo

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo" 

```
This example will get a feature rollout policy and expand appliesto

