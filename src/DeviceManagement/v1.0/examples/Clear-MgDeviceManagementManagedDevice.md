### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	keepEnrollmentData = $true
	keepUserData = $true
	macOsUnlockCode = "Mac Os Unlock Code value"
	persistEsimDataPlan = $true
}

Clear-MgDeviceManagementManagedDevice -ManagedDeviceId $managedDeviceId -BodyParameter $params

```
This example shows how to use the Clear-MgDeviceManagementManagedDevice Cmdlet.

