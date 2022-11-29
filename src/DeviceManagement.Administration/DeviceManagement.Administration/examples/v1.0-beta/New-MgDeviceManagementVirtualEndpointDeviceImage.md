### Example 1: Using the New-MgDeviceManagementVirtualEndpointDeviceImage Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcDeviceImage"
	DisplayName = "Display Name value"
	OsBuildNumber = "OS Build Number value"
	OperatingSystem = "Operating System value"
	Version = "Version value"
	SourceImageResourceId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c58ffff/resourceGroups/Example/providers/Microsoft.Compute/images/exampleImage"
}
New-MgDeviceManagementVirtualEndpointDeviceImage -BodyParameter $params
```
This example shows how to use the New-MgDeviceManagementVirtualEndpointDeviceImage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
