### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	policySettings = "region"
	reservePercentage = 80
}

Add-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -BodyParameter $params

```
This example shows how to use the Add-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.

