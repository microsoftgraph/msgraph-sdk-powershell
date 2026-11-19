### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	cloudPcSnapshotId = "A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8"
}

Restore-MgDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params

```
This example shows how to use the Restore-MgDeviceManagementVirtualEndpointCloudPc Cmdlet.

