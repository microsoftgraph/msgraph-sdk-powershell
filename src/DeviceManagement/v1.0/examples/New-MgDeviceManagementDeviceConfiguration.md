### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	allowSampleSharing = $true
	enableExpeditedTelemetryReporting = $true
}

New-MgDeviceManagementDeviceConfiguration -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceConfiguration Cmdlet.

