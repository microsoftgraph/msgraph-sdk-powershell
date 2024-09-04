### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.enrichedAuditLogs"
	sharepoint = @{
		"@odata.type" = "microsoft.graph.networkaccess.enrichedAuditLogsSettings"
	}
	teams = @{
		"@odata.type" = "microsoft.graph.networkaccess.enrichedAuditLogsSettings"
	}
	exchange = @{
		"@odata.type" = "microsoft.graph.networkaccess.enrichedAuditLogsSettings"
	}
}

Update-MgBetaNetworkAccessSettingEnrichedAuditLog -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessSettingEnrichedAuditLog Cmdlet.

