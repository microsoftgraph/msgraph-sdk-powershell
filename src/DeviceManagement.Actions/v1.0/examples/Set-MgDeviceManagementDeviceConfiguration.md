### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	assignments = @(
		@{
			"@odata.type" = "#microsoft.graph.deviceConfigurationAssignment"
			id = "d59b6342-6342-d59b-4263-9bd542639bd5"
			target = @{
				"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
				collectionId = "Collection Id value"
			}
		}
	)
}

Set-MgDeviceManagementDeviceConfiguration -DeviceConfigurationId $deviceConfigurationId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceManagementDeviceConfiguration Cmdlet.

