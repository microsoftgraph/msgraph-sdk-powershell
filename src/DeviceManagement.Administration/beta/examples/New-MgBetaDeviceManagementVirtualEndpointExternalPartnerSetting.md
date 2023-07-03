### Example 1: Using the New-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcExternalPartnerSetting"
	PartnerId = "198d7140-80bb-4843-8cc4-811377a49a92"
	EnableConnection = $true
}
New-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting -BodyParameter $params
```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointExternalPartnerSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
