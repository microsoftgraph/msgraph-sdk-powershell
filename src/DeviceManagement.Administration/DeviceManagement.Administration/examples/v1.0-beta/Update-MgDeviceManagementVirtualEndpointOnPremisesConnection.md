### Example 1: Using the Update-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcOnPremisesConnection"
	DisplayName = "Display Name value"
	SubscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c585ffff"
	SubscriptionName = "Subscription Name value"
	AdDomainName = "Active Directory Domain Name value"
	AdDomainUsername = "Active Directory Domain User Name value"
	OrganizationalUnit = "Organization Unit value"
	ResourceGroupId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ffff/resourceGroups/ExampleRG"
	VirtualNetworkId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c58ffff/resourceGroups/ExampleRG/providers/Microsoft.Network/virtualNetworks/ExampleVNet"
	SubnetId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ffff/resourceGroups/ExampleRG/providers/Microsoft.Network/virtualNetworks/ExampleVNet/subnets/default"
}
Update-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
