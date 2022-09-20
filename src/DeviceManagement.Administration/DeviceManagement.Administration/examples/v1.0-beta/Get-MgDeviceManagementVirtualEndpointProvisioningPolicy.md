### Example 1: Using the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -ExpandProperty "assignments" 
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointProvisioningPolicy -CloudPcProvisioningPolicyId $cloudPcProvisioningPolicyId -Property "id,description,displayName,displayName,domainJoinConfiguration,imageDisplayName,imageId,imageType,onPremisesConnectionId,windowsSettings,managedBy,cloudPcGroupDisplayName,gracePeriodInHours,localAdminEnabled,alternateResourceUrl" 
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointProvisioningPolicy
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointProvisioningPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
