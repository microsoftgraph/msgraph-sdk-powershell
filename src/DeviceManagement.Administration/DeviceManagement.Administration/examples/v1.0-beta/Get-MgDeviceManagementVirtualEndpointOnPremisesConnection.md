### Example 1: Using the Get-MgDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointOnPremisesConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointOnPremisesConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -Property "id,displayName,healthCheckStatus,healthCheckStatusDetails,inUse" 
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
Get-MgDeviceManagementVirtualEndpointOnPremisesConnection
```
This example shows how to use the Get-MgDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
