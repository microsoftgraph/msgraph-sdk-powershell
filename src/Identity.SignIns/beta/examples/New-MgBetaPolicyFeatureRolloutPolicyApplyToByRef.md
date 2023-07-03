### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/2441b489-4f12-4882-b039-8f6006bd66da"
}

New-MgBetaPolicyFeatureRolloutPolicyApplyToByRef -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyFeatureRolloutPolicyApplyToByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

