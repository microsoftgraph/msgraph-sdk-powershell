### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcOrganizationSettings"
	enableMEMAutoEnroll = $true
	osVersion = "windows11"
	userAccountType = "standardUser"
	windowsSettings = @{
		language = "en-US"
	}
}

Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting -BodyParameter $params

```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet.

