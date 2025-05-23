### Example 1: Get the properties of the specified provisioning policy

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId

```
This example will get the properties of the specified provisioning policy

### Example 2: Get the properties of the specified provisioning policy and expand on the assignments

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -ExpandProperty "assignments" 

```
This example will get the properties of the specified provisioning policy and expand on the assignments

### Example 3: Get the selected properties of the specified provisioning policy

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -Property "id,description,displayName,domainJoinConfigurations,imageDisplayName,imageId,imageType,windowsSetting,managedBy,cloudPcGroupDisplayName,gracePeriodInHours,localAdminEnabled,alternateResourceUrl" 

```
This example will get the selected properties of the specified provisioning policy

