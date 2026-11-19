### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.tlsInspectionPolicyLink"
	state = "enabled"
	policy = @{
		"@odata.type" = "#microsoft.graph.networkaccess.tlsInspectionPolicy"
		id = "b712c469-e7cd-e7cb-738f-94b199570b0d"
	}
}

New-MgBetaNetworkAccessFilteringProfilePolicy -FilteringProfileId $filteringProfileId -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessFilteringProfilePolicy Cmdlet.

