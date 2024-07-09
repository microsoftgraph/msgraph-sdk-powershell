### Example 1: Get the default properties of an Azure network connection

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointOnPremiseConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId

```
This example will get the default properties of an azure network connection

### Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetails

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointOnPremiseConnection -CloudPcOnPremisesConnectionId $cloudPcOnPremisesConnectionId -Property "id,displayName,healthCheckStatus,healthCheckStatusDetail,healthCheckStatusDetails,inUse" 

```
This example will get the selected properties of an azure network connection, including healthcheckstatusdetails

