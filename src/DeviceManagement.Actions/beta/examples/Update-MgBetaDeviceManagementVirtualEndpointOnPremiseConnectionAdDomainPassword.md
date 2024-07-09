### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	adDomainPassword = "AdDomainPassword value"
}

Update-MgBetaDeviceManagementVirtualEndpointOnPremiseConnectionAdDomainPassword -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointOnPremiseConnectionAdDomainPassword Cmdlet.

