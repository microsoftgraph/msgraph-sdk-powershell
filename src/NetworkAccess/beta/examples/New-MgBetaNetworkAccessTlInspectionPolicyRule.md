### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.tlsInspectionRule"
	name = "Contoso TLS Rule 1"
	priority = 
	description = "My TLS rule"
	action = "inspect"
	settings = @{
		status = "enabled"
	}
	matchingConditions = @{
		destinations = @(
			@{
				"@odata.type" = "#microsoft.graph.networkaccess.tlsInspectionFqdnDestination"
				values = @(
				"www.contoso.test.com"
			"*.contoso.org"
		)
	}
	@{
		"@odata.type" = "#microsoft.graph.networkaccess.tlsInspectionWebCategoriesDestination"
		values = @(
		"Entertainment"
	)
}
)
}
}

New-MgBetaNetworkAccessTlInspectionPolicyRule -TlsInspectionPolicyId $tlsInspectionPolicyId -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessTlInspectionPolicyRule Cmdlet.

