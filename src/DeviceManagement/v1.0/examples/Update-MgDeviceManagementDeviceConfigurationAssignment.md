### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceConfigurationAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
		collectionId = "Collection Id value"
	}
}

Update-MgDeviceManagementDeviceConfigurationAssignment -DeviceConfigurationId $deviceConfigurationId -DeviceConfigurationAssignmentId $deviceConfigurationAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceConfigurationAssignment Cmdlet.

