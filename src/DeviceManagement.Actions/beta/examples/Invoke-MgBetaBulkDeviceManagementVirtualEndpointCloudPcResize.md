### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	cloudPcIds = @(
	"30d0e128-de93-41dc-89ec-33d84bb662a0"
"7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
)
targetServicePlanId = "662009bc-7732-4f6f-8726-25883518b33e"
}

Invoke-MgBetaBulkDeviceManagementVirtualEndpointCloudPcResize -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaBulkDeviceManagementVirtualEndpointCloudPcResize Cmdlet.

