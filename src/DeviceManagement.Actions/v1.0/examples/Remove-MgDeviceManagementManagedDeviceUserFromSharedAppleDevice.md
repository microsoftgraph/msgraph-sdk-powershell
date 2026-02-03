### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	userPrincipalName = "User Principal Name value"
}

Remove-MgDeviceManagementManagedDeviceUserFromSharedAppleDevice -ManagedDeviceId $managedDeviceId -BodyParameter $params

```
This example shows how to use the Remove-MgDeviceManagementManagedDeviceUserFromSharedAppleDevice Cmdlet.

