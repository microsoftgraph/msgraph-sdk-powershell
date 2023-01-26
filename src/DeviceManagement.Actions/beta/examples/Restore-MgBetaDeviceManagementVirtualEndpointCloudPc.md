### Example 1: Using the Restore-MgBetaDeviceManagementVirtualEndpointCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	CloudPcSnapshotId = "A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8"
}
Restore-MgBetaDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params
```
This example shows how to use the Restore-MgBetaDeviceManagementVirtualEndpointCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
