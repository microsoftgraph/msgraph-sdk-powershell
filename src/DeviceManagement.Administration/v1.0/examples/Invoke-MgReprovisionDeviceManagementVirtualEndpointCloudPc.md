### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	userAccountType = "administrator"
	osVersion = "windows10"
}

Invoke-MgReprovisionDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params

```
This example shows how to use the Invoke-MgReprovisionDeviceManagementVirtualEndpointCloudPc Cmdlet.

