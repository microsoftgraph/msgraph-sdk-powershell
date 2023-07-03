### Example 1: Using the Update-MgBetaDeviceManagementVirtualEndpointOnPremisConnectionAdDomainPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions
$params = @{
	AdDomainPassword = "AdDomainPassword value"
}
Update-MgBetaDeviceManagementVirtualEndpointOnPremisConnectionAdDomainPassword -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointOnPremisConnectionAdDomainPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
