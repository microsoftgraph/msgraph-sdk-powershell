### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "Default TLS Inspection Policy"
	description = "Policy for inspecting TLS traffic"
	settings = @{
		defaultAction = "bypass"
	}
}

New-MgBetaNetworkAccessTlInspectionPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessTlInspectionPolicy Cmdlet.

