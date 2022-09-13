###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/2441b489-4f12-4882-b039-8f6006bd66da"
}
New-MgPolicyFeatureRolloutPolicyApplyToByRef -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
