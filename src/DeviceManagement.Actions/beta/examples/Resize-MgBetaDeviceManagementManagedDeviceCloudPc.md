### Example 1: Using the Resize-MgBetaDeviceManagementManagedDeviceCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	TargetServicePlanId = "30d0e128-de93-41dc-89ec-33d84bb662a0"
}
Resize-MgBetaDeviceManagementManagedDeviceCloudPc -ManagedDeviceId $managedDeviceId -BodyParameter $params
```
This example shows how to use the Resize-MgBetaDeviceManagementManagedDeviceCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
