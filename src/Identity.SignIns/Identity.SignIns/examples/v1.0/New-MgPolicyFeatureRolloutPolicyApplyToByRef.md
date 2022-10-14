### Example 1: Using the New-MgPolicyFeatureRolloutPolicyApplyToByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/2441b489-4f12-4882-b039-8f6006bd66da"
}
New-MgPolicyFeatureRolloutPolicyApplyToByRef -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
This example shows how to use the New-MgPolicyFeatureRolloutPolicyApplyToByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
