### Example 1: Using the Get-MgDeviceManagementVirtualEndpointCloudPC Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointCloudPC -CloudPCId $cloudPCId
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointCloudPC Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDeviceManagementVirtualEndpointCloudPC Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointCloudPC -CloudPCId $cloudPCId -Property "id,displayName,imageDisplayName,lastModifiedDateTime,lastRemoteActionResult,lastLoginResult,connectivityResult" 
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointCloudPC Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgDeviceManagementVirtualEndpointCloudPC Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointCloudPC
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointCloudPC Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
