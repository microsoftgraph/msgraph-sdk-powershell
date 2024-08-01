### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	enrollmentConfigurationAssignments = @(
		@{
			"@odata.type" = "#microsoft.graph.enrollmentConfigurationAssignment"
			id = "705b021c-021c-705b-1c02-5b701c025b70"
			target = @{
				"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
				collectionId = "Collection Id value"
			}
		}
	)
}

Set-MgDeviceManagementDeviceEnrollmentConfiguration -DeviceEnrollmentConfigurationId $deviceEnrollmentConfigurationId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceManagementDeviceEnrollmentConfiguration Cmdlet.

