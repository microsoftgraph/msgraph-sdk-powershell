### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.deviceEnrollmentLimitConfiguration"
	displayName = "Display Name value"
	description = "Description value"
	priority = 8
	version = 7
	limit = 
}

Update-MgDeviceManagementDeviceEnrollmentConfiguration -DeviceEnrollmentConfigurationId $deviceEnrollmentConfigurationId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceEnrollmentConfiguration Cmdlet.

