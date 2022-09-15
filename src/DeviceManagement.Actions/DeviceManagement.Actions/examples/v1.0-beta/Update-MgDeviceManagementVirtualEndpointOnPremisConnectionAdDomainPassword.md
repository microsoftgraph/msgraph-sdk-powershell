### Example 1: Using the Update-MgDeviceManagementVirtualEndpointOnPremisConnectionAdDomainPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Actions
$params = @{
	AdDomainPassword = "AdDomainPassword value"
}
Update-MgDeviceManagementVirtualEndpointOnPremisConnectionAdDomainPassword -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -BodyParameter $params
```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointOnPremisConnectionAdDomainPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
