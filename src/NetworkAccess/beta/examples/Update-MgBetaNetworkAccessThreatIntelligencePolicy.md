### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.threatIntelligencePolicy"
	id = "a8352c78-90c6-4edd-aaca-9dc4292e7750"
	name = "Threat Intel Policy"
	description = ""
	version = "1.0.0"
	lastModifiedDateTime = [System.DateTime]::Parse("2025-06-18T17:34:25.8207682Z")
	settings = @{
		defaultAction = "allow"
	}
}

Update-MgBetaNetworkAccessThreatIntelligencePolicy -ThreatIntelligencePolicyId $threatIntelligencePolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessThreatIntelligencePolicy Cmdlet.

