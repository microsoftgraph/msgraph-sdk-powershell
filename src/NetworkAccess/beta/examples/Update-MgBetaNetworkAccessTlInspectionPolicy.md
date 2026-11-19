### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "New name TLS Inspection Policy"
	description = "New description policy for inspecting TLS traffic"
	settings = @{
		defaultAction = "inspect"
	}
}

Update-MgBetaNetworkAccessTlInspectionPolicy -TlsInspectionPolicyId $tlsInspectionPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessTlInspectionPolicy Cmdlet.

