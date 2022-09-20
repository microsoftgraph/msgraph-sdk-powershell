### Example 1: Using the Update-MgDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcExternalPartnerSetting"
	EnableConnection = $true
}
Update-MgDeviceManagementVirtualEndpointExternalPartnerSetting -CloudPcExternalPartnerSettingId $cloudPcExternalPartnerSettingId -BodyParameter $params
```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
