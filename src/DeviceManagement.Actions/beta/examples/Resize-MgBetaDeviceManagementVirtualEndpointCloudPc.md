### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	targetServicePlanId = "30d0e128-de93-41dc-89ec-33d84bb662a0"
}

Resize-MgBetaDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params

```
This example shows how to use the Resize-MgBetaDeviceManagementVirtualEndpointCloudPc Cmdlet.

