### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.forwardingPolicyLink"
	state = "enabled"
}

Update-MgBetaNetworkAccessForwardingProfilePolicy -ForwardingProfileId $forwardingProfileId -PolicyLinkId $policyLinkId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessForwardingProfilePolicy Cmdlet.

