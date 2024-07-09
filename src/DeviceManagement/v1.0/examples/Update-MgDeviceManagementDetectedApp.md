### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.detectedApp"
	displayName = "Display Name value"
	version = "Version value"
	sizeInByte = 10
	deviceCount = 11
	publisher = "Publisher value"
	platform = "windows"
}

Update-MgDeviceManagementDetectedApp -DetectedAppId $detectedAppId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDetectedApp Cmdlet.

