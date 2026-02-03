### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	userPrincipalName = "User Principal Name value"
	addressableUserName = "Addressable User Name value"
}

Set-MgDeviceManagementWindowsAutopilotDeviceIdentityUserToDevice -WindowsAutopilotDeviceIdentityId $windowsAutopilotDeviceIdentityId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceManagementWindowsAutopilotDeviceIdentityUserToDevice Cmdlet.

