### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.context" = "https://graph.microsoft.com/beta/networkAccess/settings/$metadata#conditionalAccess"
	signalingStatus = "disabled"
}

Update-MgBetaNetworkAccessSettingConditionalAccess -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessSettingConditionalAccess Cmdlet.

