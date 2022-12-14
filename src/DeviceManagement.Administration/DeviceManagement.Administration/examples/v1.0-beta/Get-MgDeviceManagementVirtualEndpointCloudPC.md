### Example 1: Using the Get-MgBetaDeviceManagementVirtualEndpointCloudPC Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointCloudPC -CloudPCId $cloudPCId
```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointCloudPC Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaDeviceManagementVirtualEndpointCloudPC Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointCloudPC -CloudPCId $cloudPCId -Property "id,displayName,imageDisplayName,lastModifiedDateTime,lastRemoteActionResult,lastLoginResult,connectivityResult" 
```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointCloudPC Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaDeviceManagementVirtualEndpointCloudPC Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointCloudPC
```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointCloudPC Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
