### Example 1: Using the Invoke-MgReprovisionDeviceManagementVirtualEndpointCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Actions
$params = @{
	UserAccountType = "administrator"
	OsVersion = "windows10"
}
Invoke-MgReprovisionDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params
```
This example shows how to use the Invoke-MgReprovisionDeviceManagementVirtualEndpointCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
