### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	displayName = "ImageForDev"
	version = "0.0.1"
	sourceImageResourceId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c58ffff/resourceGroups/Example/providers/Microsoft.Compute/images/exampleImage"
}

New-MgDeviceManagementVirtualEndpointDeviceImage -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementVirtualEndpointDeviceImage Cmdlet.

