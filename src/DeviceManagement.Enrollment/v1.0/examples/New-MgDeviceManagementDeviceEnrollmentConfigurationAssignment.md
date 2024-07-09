### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.enrollmentConfigurationAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
		collectionId = "Collection Id value"
	}
}

New-MgDeviceManagementDeviceEnrollmentConfigurationAssignment -DeviceEnrollmentConfigurationId $deviceEnrollmentConfigurationId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceEnrollmentConfigurationAssignment Cmdlet.

