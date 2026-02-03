### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	skipDnsLookupState = "disabled"
}

Update-MgBetaNetworkAccessSettingForwardingOption -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessSettingForwardingOption Cmdlet.

