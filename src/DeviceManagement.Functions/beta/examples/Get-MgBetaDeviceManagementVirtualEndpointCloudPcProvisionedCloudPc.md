### Example 1: Get all provisioned Cloud PCs and their default properties

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Functions

Get-MgBetaDeviceManagementVirtualEndpointCloudPcProvisionedCloudPc

```
This example will get all provisioned cloud pcs and their default properties

### Example 2: Get all provisioned Cloud PCs and specific properties

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Functions

Get-MgBetaDeviceManagementVirtualEndpointCloudPcProvisionedCloudPc -Property "id,displayName,powerState,connectivityResult,lastLoginResult,lastRemoteActionResult,osVersion,provisioningPolicyName,userAccountType" 

```
This example will get all provisioned cloud pcs and specific properties

