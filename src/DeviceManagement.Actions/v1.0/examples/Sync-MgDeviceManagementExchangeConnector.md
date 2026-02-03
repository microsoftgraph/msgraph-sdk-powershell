### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	syncType = "deltaSync"
}

Sync-MgDeviceManagementExchangeConnector -DeviceManagementExchangeConnectorId $deviceManagementExchangeConnectorId -BodyParameter $params

```
This example shows how to use the Sync-MgDeviceManagementExchangeConnector Cmdlet.

