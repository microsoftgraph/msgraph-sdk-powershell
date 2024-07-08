### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcExternalPartnerSetting"
	enableConnection = $true
}

Update-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting -CloudPcExternalPartnerSettingId $cloudPcExternalPartnerSettingId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet.

