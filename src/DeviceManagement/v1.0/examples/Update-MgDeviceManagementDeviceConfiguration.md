### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windows10CustomConfiguration"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	omaSettings = @(
		@{
			"@odata.type" = "microsoft.graph.omaSetting"
			displayName = "Display Name value"
			description = "Description value"
			omaUri = "Oma Uri value"
		}
	)
}

Update-MgDeviceManagementDeviceConfiguration -DeviceConfigurationId $deviceConfigurationId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceConfiguration Cmdlet.

