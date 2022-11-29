### Example 1: Using the Update-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcProvisioningPolicy"
	DisplayName = "HR provisioning policy"
	Description = "Provisioning policy for India HR employees"
	OnPremisesConnectionId = "4e47d0f6-6f77-44f0-8893-c0fe1701ffff"
	ImageId = "Image ID value"
	ImageDisplayName = "Image Display Name value"
	ImageType = "custom"
	WindowsSettings = @{
		Language = "en-US"
	}
}
Update-MgDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
