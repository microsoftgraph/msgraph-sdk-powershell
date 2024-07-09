### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.androidManagedAppRegistration"
	lastSyncDateTime = [System.DateTime]::Parse("2017-01-01T00:02:49.3205976-08:00")
	applicationVersion = "Application Version value"
	managementSdkVersion = "Management Sdk Version value"
	platformVersion = "Platform Version value"
	deviceType = "Device Type value"
	deviceTag = "Device Tag value"
	deviceName = "Device Name value"
	flaggedReasons = @(
	"rootedDevice"
)
userId = "User Id value"
appIdentifier = @{
	"@odata.type" = "microsoft.graph.androidMobileAppIdentifier"
	packageId = "Package Id value"
}
version = "Version value"
}

New-MgDeviceAppManagementManagedAppRegistration -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementManagedAppRegistration Cmdlet.

