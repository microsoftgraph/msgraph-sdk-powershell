### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcProvisioningPolicy"
	displayName = "HR provisioning policy"
	description = "Provisioning policy for India HR employees"
}

Update-MgDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.

