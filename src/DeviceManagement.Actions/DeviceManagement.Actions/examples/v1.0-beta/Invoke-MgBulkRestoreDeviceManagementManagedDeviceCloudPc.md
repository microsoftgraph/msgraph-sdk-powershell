### Example 1: Using the Invoke-MgBulkRestoreDeviceManagementManagedDeviceCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Actions
$params = @{
	ManagedDeviceIds = @(
		"30d0e128-de93-41dc-89ec-33d84bb662a0"
		"7c82a3e3-9459-44e4-94d9-b92f93bf78dd"
	)
	RestorePointDateTime = [System.DateTime]::Parse("2021-09-23T04:00:00.0000000")
	TimeRange = "before"
}
Invoke-MgBulkRestoreDeviceManagementManagedDeviceCloudPc -BodyParameter $params
```
This example shows how to use the Invoke-MgBulkRestoreDeviceManagementManagedDeviceCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
