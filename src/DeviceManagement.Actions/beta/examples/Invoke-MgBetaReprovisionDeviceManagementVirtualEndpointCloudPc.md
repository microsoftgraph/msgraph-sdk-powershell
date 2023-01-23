### Example 1: Using the Invoke-MgBetaReprovisionDeviceManagementVirtualEndpointCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	UserAccountType = "administrator"
	OsVersion = "windows10"
}
Invoke-MgBetaReprovisionDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaReprovisionDeviceManagementVirtualEndpointCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
