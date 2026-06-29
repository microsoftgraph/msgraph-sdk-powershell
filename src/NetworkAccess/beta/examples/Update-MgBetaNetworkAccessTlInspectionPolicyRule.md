### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "Contoso TLS Rule 1 - Updated"
	priority = 
	description = "My TLS rule - Updated"
	action = "bypass"
	settings = @{
		status = "disabled"
	}
	matchingConditions = @{
		destinations = @(
			@{
				"@odata.type" = "#microsoft.graph.networkaccess.tlsInspectionFqdnDestination"
				values = @(
				"www.contoso.test-updated.com"
			"*.contoso.org"
		)
	}
)
}
}

Update-MgBetaNetworkAccessTlInspectionPolicyRule -TlsInspectionPolicyId $tlsInspectionPolicyId -PolicyRuleId $policyRuleId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessTlInspectionPolicyRule Cmdlet.

