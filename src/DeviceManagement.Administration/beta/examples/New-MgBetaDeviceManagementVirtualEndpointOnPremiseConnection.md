### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

$params = @{
	displayName = "test-canary-02"
	connectionType = "hybridAzureADJoin"
	type = "hybridAzureADJoin"
	subscriptionId = "0ac520ee-14c0-480f-b6c9-0a90c585ffff"
	adDomainName = "contoso001.com"
	adDomainUsername = "dcadmin"
	organizationalUnit = "OU=Domain Controllers, DC=contoso001, DC=com"
	resourceGroupId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ad47/resourceGroups/CustomerRG"
	virtualNetworkId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ad47/resourceGroups/CustomerRG/providers/Microsoft.Network/virtualNetworks/canary01-MyVNET"
	subnetId = "/subscriptions/0ac520ee-14c0-480f-b6c9-0a90c585ad47/resourceGroups/CustomerRG/providers/Microsoft.Network/virtualNetworks/canary01-MyVNET/subnets/canary01-Subnet"
}

New-MgBetaDeviceManagementVirtualEndpointOnPremiseConnection -BodyParameter $params

```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointOnPremiseConnection Cmdlet.

