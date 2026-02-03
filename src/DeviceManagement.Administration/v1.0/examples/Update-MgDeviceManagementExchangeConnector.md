### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.deviceManagementExchangeConnector"
	lastSyncDateTime = [System.DateTime]::Parse("2017-01-01T00:02:49.3205976-08:00")
	status = "connectionPending"
	primarySmtpAddress = "Primary Smtp Address value"
	serverName = "Server Name value"
	connectorServerName = "Connector Server Name value"
	exchangeConnectorType = "hosted"
	version = "Version value"
	exchangeAlias = "Exchange Alias value"
	exchangeOrganization = "Exchange Organization value"
}

Update-MgDeviceManagementExchangeConnector -DeviceManagementExchangeConnectorId $deviceManagementExchangeConnectorId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementExchangeConnector Cmdlet.

