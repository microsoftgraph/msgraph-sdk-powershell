### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	quickScan = $true
}

Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender -ManagedDeviceId $managedDeviceId -BodyParameter $params

```
This example shows how to use the Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender Cmdlet.

