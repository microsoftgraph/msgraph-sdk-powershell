### Example 1: Get a feature rollout policy

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId
```
This example shows how to use the Remove-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a feature rollout policy and expand appliesTo

```powershellImport-Module Microsoft.Graph.Identity.SignIns

Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo"
```
This example shows how to use the Remove-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

