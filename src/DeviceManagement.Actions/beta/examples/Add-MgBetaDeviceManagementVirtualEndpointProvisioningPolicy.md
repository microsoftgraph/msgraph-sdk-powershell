### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	policySettings = "region"
}

Add-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -BodyParameter $params

```
This example shows how to use the Add-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.

