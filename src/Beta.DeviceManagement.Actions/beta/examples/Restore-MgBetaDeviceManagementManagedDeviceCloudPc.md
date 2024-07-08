### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	cloudPcSnapshotId = "A00009UV000_93aff428-61f2-467f-a879-1102af6fd4a8"
}

Restore-MgBetaDeviceManagementManagedDeviceCloudPc -ManagedDeviceId $managedDeviceId -BodyParameter $params

```
This example shows how to use the Restore-MgBetaDeviceManagementManagedDeviceCloudPc Cmdlet.

