### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	userAccountType = "administrator"
}

Rename-MgBetaDeviceManagementVirtualEndpointCloudPcUserAccountType -CloudPCId $cloudPCId -BodyParameter $params

```
This example shows how to use the Rename-MgBetaDeviceManagementVirtualEndpointCloudPcUserAccountType Cmdlet.

