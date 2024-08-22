### Example 1: Get the default properties of a Cloud PC

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId

```
This example will get the default properties of a cloud pc

### Example 2: Get the selected properties of a Cloud PC

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointCloudPc -CloudPCId $cloudPCId -Property "id,displayName,imageDisplayName,lastModifiedDateTime,lastRemoteActionResult,lastLoginResult,connectivityResult,allotmentDisplayName,deviceRegionName" 

```
This example will get the selected properties of a cloud pc

### Example 4: List Cloud PCs filtered by disaster recovery capability type

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration

Get-MgBetaDeviceManagementVirtualEndpointCloudPc -Property "id,displayName,disasterRecoveryCapability" -Filter "disasterRecoveryCapability/capabilityType eq 'failover'" 

```
This example will list cloud pcs filtered by disaster recovery capability type

