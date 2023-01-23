### Example 1: Using the Update-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcExternalPartnerSetting"
	EnableConnection = $true
}
Update-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting -CloudPcExternalPartnerSettingId $cloudPcExternalPartnerSettingId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
