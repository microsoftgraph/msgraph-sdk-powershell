### Example 1: Using the Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId
```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -Property "id,displayName,healthCheckStatus,healthCheckStatusDetails,inUse" 
```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection
```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointOnPremisesConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
