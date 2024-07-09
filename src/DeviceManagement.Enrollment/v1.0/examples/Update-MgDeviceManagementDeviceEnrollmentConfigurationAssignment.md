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

Update-MgDeviceManagementDeviceEnrollmentConfigurationAssignment -DeviceEnrollmentConfigurationId $deviceEnrollmentConfigurationId -EnrollmentConfigurationAssignmentId $enrollmentConfigurationAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceEnrollmentConfigurationAssignment Cmdlet.

