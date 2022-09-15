### Example 1: Using the Rename-MgDeviceManagementVirtualEndpointCloudPcUserAccountType Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Actions
$params = @{
	UserAccountType = "administrator"
}
Rename-MgDeviceManagementVirtualEndpointCloudPcUserAccountType -CloudPCId $cloudPCId -BodyParameter $params
```
This example shows how to use the Rename-MgDeviceManagementVirtualEndpointCloudPcUserAccountType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
