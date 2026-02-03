### Example 1: Using the New-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcOnPremisesConnection"
	DisplayName = "test-canary-02"
	Type = "hybridAzureADJoin"
	SubscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c585ffff"
	SubscriptionName = "CPC customer 001 test subscription"
	AdDomainName = "contoso001.com"
	AdDomainUsername = "dcadmin"
	OrganizationalUnit = "OU=Domain Controllers, DC=contoso001, DC=com"
	ResourceGroupId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ad47/resourceGroups/CustomerRG"
	VirtualNetworkId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ad47/resourceGroups/CustomerRG/providers/Microsoft.Network/virtualNetworks/canary01-MyVNET"
	SubnetId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ad47/resourceGroups/CustomerRG/providers/Microsoft.Network/virtualNetworks/canary01-MyVNET/subnets/canary01-Subnet"
}
New-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection -BodyParameter $params
```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
