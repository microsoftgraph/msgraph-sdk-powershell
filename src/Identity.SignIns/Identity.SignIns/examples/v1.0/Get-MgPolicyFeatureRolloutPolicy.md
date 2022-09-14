### Example 1: Using the Get-MgPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy
```
This example shows how to use the Get-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -ExpandProperty "appliesTo" 
```
This example shows how to use the Get-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId
```
This example shows how to use the Get-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
