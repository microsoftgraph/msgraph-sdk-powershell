### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	state = "enabled"
	configuration = @{
		"@odata.type" = "#microsoft.graph.networkaccess.markdownBlockMessageConfiguration"
		body = "Your admin at NaaSLitware has blocked your access. [Click here for NaaSLitware's Terms of Use](https://www.bing.com)."
	}
}

Update-MgBetaNetworkAccessSettingCustomBlockPage -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessSettingCustomBlockPage Cmdlet.

