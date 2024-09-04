### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.crossTenantAccessSettings"
	networkPacketTaggingStatus = "enabled"
}

Update-MgBetaNetworkAccessSettingCrossTenantAccess -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessSettingCrossTenantAccess Cmdlet.

