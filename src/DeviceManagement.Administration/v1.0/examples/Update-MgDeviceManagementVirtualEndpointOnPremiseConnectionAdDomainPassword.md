### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	adDomainPassword = "AdDomainPassword_XXXX"
}

Update-MgDeviceManagementVirtualEndpointOnPremiseConnectionAdDomainPassword -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointOnPremiseConnectionAdDomainPassword Cmdlet.

