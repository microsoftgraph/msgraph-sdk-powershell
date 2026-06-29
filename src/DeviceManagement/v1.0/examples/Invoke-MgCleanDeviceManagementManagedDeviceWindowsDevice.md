### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	keepUserData = $true
}

Invoke-MgCleanDeviceManagementManagedDeviceWindowsDevice -ManagedDeviceId $managedDeviceId -BodyParameter $params

```
This example shows how to use the Invoke-MgCleanDeviceManagementManagedDeviceWindowsDevice Cmdlet.

