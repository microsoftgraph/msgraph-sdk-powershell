### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windows10EnterpriseModernAppManagementConfiguration"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	uninstallBuiltInApps = $true
}

New-MgDeviceManagementDeviceConfiguration -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceConfiguration Cmdlet.

