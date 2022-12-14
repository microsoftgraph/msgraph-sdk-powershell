### Example 1: Using the Rename-MgBetaDeviceManagementVirtualEndpointCloudPcUserAccountType Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	UserAccountType = "administrator"
}
Rename-MgBetaDeviceManagementVirtualEndpointCloudPcUserAccountType -CloudPCId $cloudPCId -BodyParameter $params
```
This example shows how to use the Rename-MgBetaDeviceManagementVirtualEndpointCloudPcUserAccountType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
