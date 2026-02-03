### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	updateWindowsDeviceAccountActionParameter = @{
		"@odata.type" = "microsoft.graph.updateWindowsDeviceAccountActionParameter"
		deviceAccount = @{
			"@odata.type" = "microsoft.graph.windowsDeviceAccount"
			password = "Password value"
		}
		passwordRotationEnabled = $true
		calendarSyncEnabled = $true
		deviceAccountEmail = "Device Account Email value"
		exchangeServer = "Exchange Server value"
		sessionInitiationProtocalAddress = "Session Initiation Protocal Address value"
	}
}

Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount -ManagedDeviceId $managedDeviceId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount Cmdlet.

