### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	cloudPcIds = @(
	"52aa2645-36ee-47d2-9eb3-b8fbb17c3fc4"
"ff117b6c-e3e6-41be-9cae-eb6743249a30"
)
policySettings = "region"
}

Add-MgBetaDeviceManagementVirtualEndpointProvisioningPolicyConfig -BodyParameter $params

```
This example shows how to use the Add-MgBetaDeviceManagementVirtualEndpointProvisioningPolicyConfig Cmdlet.

