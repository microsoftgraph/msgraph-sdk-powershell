### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsInformationProtectionNetworkLearningSummary"
	url = "Url value"
	deviceCount = 11
}

New-MgDeviceManagementWindowsInformationProtectionNetworkLearningSummary -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementWindowsInformationProtectionNetworkLearningSummary Cmdlet.

