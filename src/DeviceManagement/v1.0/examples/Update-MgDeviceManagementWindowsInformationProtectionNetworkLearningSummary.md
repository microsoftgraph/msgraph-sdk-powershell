### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsInformationProtectionNetworkLearningSummary"
	url = "Url value"
	deviceCount = 11
}

Update-MgDeviceManagementWindowsInformationProtectionNetworkLearningSummary -WindowsInformationProtectionNetworkLearningSummaryId $windowsInformationProtectionNetworkLearningSummaryId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementWindowsInformationProtectionNetworkLearningSummary Cmdlet.

