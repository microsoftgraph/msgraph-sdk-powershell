### Example 1: Get a feature rollout policy

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId
```
This example shows how to use the Remove-MgBetaBetaPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a feature rollout policy and expand appliesTo

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo"
```
This example shows how to use the Remove-MgBetaBetaPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

