### Example 1: Reprovision the cloudPC for the administrator

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	userAccountType = "administrator"
	osVersion = "windows10"
}

Invoke-MgBetaReprovisionDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -BodyParameter $params

```
This example will reprovision the cloudpc for the administrator

