### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcExternalPartnerSetting"
	partnerId = "198d7140-80bb-4843-8cc4-811377a49a92"
	enableConnection = $true
}

New-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting -BodyParameter $params

```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet.

