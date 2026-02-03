### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsInformationProtectionAppLearningSummary"
	applicationName = "Application Name value"
	applicationType = "desktop"
	deviceCount = 11
}

New-MgDeviceManagementWindowsInformationProtectionAppLearningSummary -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementWindowsInformationProtectionAppLearningSummary Cmdlet.

