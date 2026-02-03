### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	priority = 8
}

Set-MgDeviceManagementDeviceEnrollmentConfigurationPriority -DeviceEnrollmentConfigurationId $deviceEnrollmentConfigurationId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceManagementDeviceEnrollmentConfigurationPriority Cmdlet.

